using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using DTO;

namespace DAL
{
    public class NhapLinhKien_funcs
    {
        DataSQL dtsql = new DataSQL();
        HoaDonMua_funcs hdm = new HoaDonMua_funcs();
        qlLinhKienLINQDataContext qllk = new qlLinhKienLINQDataContext();

        // lay ds du lieu hoa don mua va ct hoa don
        public List<HOADON_MUAHANG> LayDSHoaDon_MuaHang()
        {
            return qllk.HOADON_MUAHANGs.Where(hdmh => hdmh.TinhTrang == false).ToList<HOADON_MUAHANG>();
        }

        public int CountHDM()
        {
            string sql="select count(*) from HOADON_MUAHANG where TinhTrang=0";
            return (int)dtsql.ExecuteScalar(sql);
        }

        public DataTable getHDM()
        {
            string sql = "select * from HOADON_MUAHANG where TinhTrang=0 ";
            return dtsql.ExecQuery(sql);
        }


        public List<CT_HoaDonMua> LayCT_HoaDonMua(string maHD)
        {
            var ct_hdm = from ct in qllk.CT_HOADONMUAs
                         join lk in qllk.LINHKIENs on ct.MaLK equals lk.MaLK
                         join loai in qllk.LOAI_LKs on lk.LoaiLK equals loai.MaLoai
                         join hdmh in qllk.HOADON_MUAHANGs on ct.MaHDM equals hdmh.MaHD
                         join ncc in qllk.NHACUNGCAPs on hdmh.MaNCC equals ncc.MaNCC
                         where ct.MaHDM == maHD
                         select new { ct.MaLK, lk.TenLK, loai.MaLoai, lk.NhaSX, ct.SoLuong };
            var kq = ct_hdm.ToList().ConvertAll(t => new CT_HoaDonMua()
            {
                MaLK = t.MaLK,
                TenLK = t.TenLK,
                LoaiLK = t.MaLoai,
                NhaSX = t.NhaSX,
                SoLuong = t.SoLuong
            });
            return kq.ToList<CT_HoaDonMua>();
        }

        public bool kiemtraTrungIdPN(string p)
        {
            var kt = from k in qllk.PHIEUNHAPs
                     where k.MaPN == p
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public bool kiemtraTrungIdCTPN(string p)
        {
            var kt = from k in qllk.CT_PHIEUNHAPs
                     where k.Ma_CTPN == p
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public void capNhatTinhTrangHDM(string _maHDM)
        {
            //update for LINQ
            HOADON_MUAHANG hdm = new HOADON_MUAHANG();
            hdm = qllk.HOADON_MUAHANGs.Where(t => t.MaHD == _maHDM).FirstOrDefault();
            if (hdm != null)
            {
                hdm.TinhTrang = true;
                qllk.SubmitChanges();
            }
        }

        public string layIdNCC(string _maHDM)
        {
            var kt = (from k in qllk.HOADON_MUAHANGs
                      where k.MaHD == _maHDM
                      select k.MaNCC).FirstOrDefault();
            string mancc = kt.ToString();
            return mancc;
        }

        public string layTenNCC(string _maNCC)
        {
            var kt = (from k in qllk.NHACUNGCAPs
                      where k.MaNCC == _maNCC
                      select k.TenNCC).FirstOrDefault();
            string tenncc = kt.ToString();
            return tenncc;
        }

        
    }
}
