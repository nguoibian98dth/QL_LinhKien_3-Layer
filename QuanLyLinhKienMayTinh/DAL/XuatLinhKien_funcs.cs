using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XuatLinhKien_funcs
    {
        DataSQL dtsql = new DataSQL();
        public qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();

        public bool kiemtraTrungIdPX(string p)
        {
            var kt = from k in _qllk.PHIEUXUATs
                     where k.MaPX == p
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public bool kiemtraTrungIdCTPX(string p)
        {
            var kt = from k in _qllk.CT_PHIEUXUATs
                     where k.Ma_CTPX == p
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public bool capNhatTinhTrangHDB(string _maHDB)
        {
            try
            {
                //update for LINQ
                HOADON_BANHANG hdb = new HOADON_BANHANG();
                hdb = _qllk.HOADON_BANHANGs.Where(t => t.MaHD == _maHDB).FirstOrDefault();
                if (hdb != null)
                {
                    hdb.TinhTrang = true;
                    _qllk.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public DataTable LayCT_HoaDonBan(string _maHDBan)
        {
            string sql = "select ct.maLK,lk.tenLK,l.TenLoai,lk.NhaSX , ct.soLuong " +
                            "from CT_HOADONBAN ct, LinhKien lk, Loai_LK l, HoaDon_BanHang b where ct.maLK = lk.MaLK and lk.loaiLK = l.MaLoai and ct.maHDB = b.MaHD and ct.maHDB = '" + _maHDBan.ToString() + "' ";

            return dtsql.ExecQuery(sql);
        }

        public string layIdKH(string _maHDB)
        {
            var kt = (from k in _qllk.HOADON_BANHANGs
                      where k.MaHD == _maHDB
                      select k.MaKH).FirstOrDefault();
            string flag = kt.ToString();
            return flag;
        }

        public string layTenKH(string _maKH)
        {
            var kt = (from k in _qllk.KHACHHANGs
                      where k.MaKH == _maKH
                      select k.TenKH).FirstOrDefault();
            string flag = kt.ToString();
            return flag;
        }

        public DataTable LayDSHoaDon_BanHang()
        {
            string sql = "select MaHD from HOADON_BANHANG where TinhTrang = 0";
            return dtsql.ExecQuery(sql);
        }
    }
}
