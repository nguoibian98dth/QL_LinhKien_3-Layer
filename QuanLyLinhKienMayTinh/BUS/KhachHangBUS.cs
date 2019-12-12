using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
       
        LinhKienBUS lkBUS = new LinhKienBUS();
        KhachHang_func khDAL = new KhachHang_func();

        public bool CapNhatKH(KhachHang kh)
        {
            return khDAL.CapNhatKhachHang(kh);        
        }

        public string taoMaKH()
        {
            string title = "KH";
            Random rand = new Random();
            string a = rand.Next(1000000, 9999999).ToString();
            return title + a + lkBUS.RandomString(2, true);
        }

        public bool kiemtraTrungIdKH(string _maKH)
        {
            return khDAL.kiemtraTrungIdKH(_maKH);
        }

        public bool kiemtraTrungSDT(string p)
        {
            return khDAL.kiemtraTrungSDT(p);
        }

    }
}
