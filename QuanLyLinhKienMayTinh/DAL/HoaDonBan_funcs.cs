
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonBan_funcs
    {
        DataSQL dtsql = new DataSQL();
        qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();
        protected static SqlConnection conn = new SqlConnection(DAL.Properties.Settings.Default.QLLinhKienMayTinhConnectionString);

        public DataTable LayDSHoaDonBan(string _maNV)
        {
            try
            {
                string sql = "SELECT MaHD,NgayLap,kh.MaKH,TenKH,DienThoai,DiaChi,TongTien FROM HOADON_BANHANG hdb, KHACHHANG kh WHERE hdb.MaKH=kh.MaKH and TinhTrang=1 AND MaNV='" + _maNV + "' Order by NgayLap desc";
                return dtsql.ExecQuery(sql);
            }
            catch
            {
                return null;
            }
        }

        public bool kiemtraTrungIdHDBan(string p)
        {
            var kt = from k in _qllk.HOADON_BANHANGs
                     where k.MaHD == p
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public bool kiemtraTrungIdCTHDBan(string p)
        {
            var kt = from k in _qllk.CT_HOADONBANs
                     where k.Ma_CTHD == p
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public List<string> fillDataOnTextbox(string sdtKhach)
        {
            List<String> listDL = new List<string>();
            string maKH = "";
            string tenKH = "";
            string diaChiKH = "";

            SqlDataReader rdr = null;
            string sql_kh = "Select MaKH, TenKH, DiaChi From KHACHHANG Where DienThoai= '" + sdtKhach + "'";
            SqlCommand cmd = new SqlCommand(sql_kh, conn);
            cmd.CommandText = sql_kh;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // get the results of each column
                    maKH = (string)rdr["MaKH"];
                    tenKH = (string)rdr["TenKH"];
                    diaChiKH = (string)rdr["DiaChi"];
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                
                listDL.Add(maKH);
                listDL.Add(tenKH);
                listDL.Add(diaChiKH);
                
            }
            return listDL;

        }
    
    }
}
