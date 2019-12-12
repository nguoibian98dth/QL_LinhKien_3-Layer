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
    public class NhaCungCap_func
    {
        DataSQL dtsql = new DataSQL();
        qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();
        KiemTra kt = new KiemTra();
        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                //tao cau truy van
                string sql_ThemNCC = "insert into NHACUNGCAP values ('" + ncc.MaNCC + "',N'" + ncc.TenNCC + "',N'" + ncc.DiaChi + "','" + ncc.DienThoai + "','" + ncc.SoTaiKhoan + "','" + ncc.NgayDangKy + "')";

                //thuc thi cau truy van
                dtsql.ExecNonQuery(sql_ThemNCC);
                return true;
            }
            catch
            {
                return false;
            }
        }
        // Xoa NhaCC khoi DS
        public bool XoaNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                // tao cau truy van
                string sql_XoaNCC = "delete from NHACUNGCAP where MaNCC = '" + ncc.MaNCC.ToString() +"'";

                // thuc thi cau truy van
                dtsql.ExecNonQuery(sql_XoaNCC);
                return true;
            }
            catch
            {
                
                return false;
            }
        }

        // Cap nhat NhaCC
        public bool CapNhatNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                // tao cau truy van
                string sql_SuaNCC = "update NhaCungCap set " + "tenNCC = " + "'" + ncc.TenNCC + "' ," + "DiaChi = " + "'" + ncc.DiaChi + "'," + "DienThoai = " + "'" + ncc.DienThoai + "'," + "SoTaiKhoan = " + "'" + ncc.SoTaiKhoan + "'," + "NgayDangKy = " + "'" + ncc.NgayDangKy + "'" + "where MaNCC = '" + ncc.MaNCC + "'";

                // thuc thi cau truy van
                dtsql.ExecNonQuery(sql_SuaNCC);
                return true;
            }
            catch
            {
                return false;
            }
        }

       

        public bool KiemTraKhiThemNCC(string _tenMoi, string _diaChiMoi)
        {
            string sql_tenNCC = "select TenNCC from NhaCungCap";
            string sql_diaChi = "select DiaChi from NhaCungCap";

            if (kt.KiemTraDL(sql_tenNCC, _tenMoi, 0) == false && kt.KiemTraDL(sql_diaChi, _diaChiMoi, 0) == false)
            {              
                return false;
            }
            return true;
        }

        public bool KiemTraKhiCapNhatNCC(string _tenMoi, string _diaChiMoi, int _dongDangChon)
        {
            string sql_tenNCC = "select tenNhaCC from NhaCungCap";
            string sql_diaChi = "select diaChi from NhaCungCap";

            if (kt.KiemTraDL2(sql_tenNCC, _tenMoi, 0, _dongDangChon) == false && kt.KiemTraDL2(sql_diaChi, _diaChiMoi, 0, _dongDangChon) == false)
            {
                //MessageBox.Show("Đã Tồn Tại Nhà Cung Cấp << " + _tenMoi.ToString() + " >> Trong Danh Sách !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool kiemtraTrungIdNCC(string maNCC)
        {
            var kt = from k in _qllk.NHACUNGCAPs
                     where k.MaNCC == maNCC
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

    }
}
