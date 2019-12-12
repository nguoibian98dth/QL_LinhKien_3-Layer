using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class XuatLinhKienBUS
    {
        XuatLinhKien_funcs xlkDAL = new XuatLinhKien_funcs();

        public bool kiemtraTrungIdPX(string p)
        {
            return xlkDAL.kiemtraTrungIdCTPX(p);
        }

        public bool kiemtraTrungIdCTPX(string p)
        {

            return xlkDAL.kiemtraTrungIdCTPX(p);
        }

        public void capNhatTinhTrangHDB(string _maHDB)
        {
            xlkDAL.capNhatTinhTrangHDB(_maHDB);
            
        }

        public DataTable LayCT_HoaDonBan(string _maHDBan)
        {
            return xlkDAL.LayCT_HoaDonBan(_maHDBan);
        }

        public string layIdKH(string _maHDB)
        {
            return xlkDAL.layIdKH(_maHDB);
        }

        public string layTenKH(string _maKH)
        {
            return xlkDAL.layTenKH(_maKH);
        }

        public DataTable LayDSHoaDon_BanHang()
        {
            return xlkDAL.LayDSHoaDon_BanHang();
        }
    }
}
