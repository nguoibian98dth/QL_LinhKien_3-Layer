using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    public class HoaDonBanBUS
    {
        HoaDonBan_funcs hdbDAL = new HoaDonBan_funcs();
        LinhKienBUS lkBUS = new LinhKienBUS();

        public DataTable LayDSHoaDonBan(string _maNV)
        {
            return hdbDAL.LayDSHoaDonBan(_maNV);
        }

        public string taoMaCTHDBan()
        {
            Random rand = new Random();
            string a = rand.Next(1000000, 9999999).ToString();
            return a + lkBUS.RandomString(4, true);
        }

        public string taoMaHDBan()
        {
            string title = "HD";
            Random rand = new Random();
            string a = rand.Next(100000, 999999).ToString();
            return title + a + lkBUS.RandomString(3, true);
        }

        public bool kiemtraTrungIdHDBan(string p)
        {
            return hdbDAL.kiemtraTrungIdHDBan(p);
        }

        public bool kiemtraTrungIdCTHDBan(string p)
        {
            return hdbDAL.kiemtraTrungIdCTHDBan(p);
        }

        public List<string> fillDataOnTextbox(string sdtKhach)
        {
            return hdbDAL.fillDataOnTextbox(sdtKhach);
        }
    }
}
