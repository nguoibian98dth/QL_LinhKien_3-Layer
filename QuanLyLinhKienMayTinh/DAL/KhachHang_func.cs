using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class KhachHang_func
    {
        DataSQL dtsql = new DataSQL();
        qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();
        protected static SqlConnection conn = new SqlConnection(DAL.Properties.Settings.Default.QLLinhKienMayTinhConnectionString);

        // Cap nhat Khach Hang
        public bool CapNhatKhachHang(KhachHang kh)
        {
            try
            {
                
                // tao cau truy van
                string sql_SuaKH = "update KhachHang set TenKH = " + "N'" + kh.TenKH + "', DiaChi =" + " N'" + kh.DiaChi + "', DienThoai =" + " '" + kh.DienThoai + "' where MaKH =" + " '" + kh.MaKH + "'";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // thuc thi cau truy van
                dtsql.ExecNonQuery(sql_SuaKH);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool kiemtraTrungIdKH(string _maKH)
        {
            var kt = from k in _qllk.KHACHHANGs
                     where k.MaKH == _maKH
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public bool kiemtraTrungSDT(string p)
        {
            var kt = from k in _qllk.KHACHHANGs
                     where k.DienThoai == p
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

     
    }
}
