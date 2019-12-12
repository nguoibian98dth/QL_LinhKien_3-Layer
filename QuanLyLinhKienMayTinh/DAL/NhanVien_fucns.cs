using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class NhanVien_fucns
    {
        DataSQL dtsql = new DataSQL();
        private qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();

        public NguoiDung LayThongTinNguoiDung(string _manv)
        {
            string sql = "Select * from NguoiDung where tenNguoiDung = '" + _manv + "'";
            DataTable dt = dtsql.ExecQuery(sql);
            if (dt.Rows.Count != 0)
            {
                NguoiDung user = new NguoiDung();
                user.Str_MaNV = _manv;
                user.Str_MaNV = dt.Rows[0][1].ToString();
                user.Str_MatKhau = dt.Rows[0][2].ToString();
                user.Str_Quyen = int.Parse(dt.Rows[0][3].ToString());
                return user;
            }
            return null;
        }

        public bool kiemTraTrungID(string id)
        {
            var kt = from k in _qllk.NHANVIENs
                     where k.MaNV == id
                     select k;
            if (kt.Count() > 0)
                return false;
            return true;
        }

        public void capnhatNVlinQ(string maNV, string hoten, DateTime ngaysinh, string gt, string email, string cmnd, string dc, string sdt)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN();
                nv = _qllk.NHANVIENs.Where(t => t.MaNV == maNV).FirstOrDefault();
                if (nv != null)
                {
                    nv.HoTen = hoten;
                    nv.NgaySinh = ngaysinh;
                    nv.GioiTinh = gt;
                    nv.Email = email;
                    nv.CMND = cmnd;
                    nv.DiaChi = dc;
                    nv.DienThoai = sdt;
                    _qllk.SubmitChanges();
                }
            }
            catch
            {
                return;
            }
        }

        public bool CapNhatNV(NhanVien nv)
        {
            try 
            { 
                string sql_Sua = "update NHANVIEN set " +
                    "HoTen = " + "N'" + nv.Str_TenNV + "' ," +
                    "NgaySinh = " + "'" + nv.NgaySinh1 + "'," +
                    "DiaChi = " + "N'" + nv.Str_DiaChi + "'," +
                    "DienThoai = " + "'" + nv.Str_DienThoai + "'," +
                    "Email = " + "'" + nv.Str_Email + "'," +
                    "CMND= " + "'" + nv.Str_cmnd + "'," +
                    "MaBC = " + "'" + nv.Str_MaBC + "', " +
                    "GioiTinh= " + "N'" + nv.Str_GT + "'" +
                    " where MaNV = " + "'" + nv.Str_MaNV + "' ";

                dtsql.ExecNonQuery(sql_Sua);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }


    }
}
