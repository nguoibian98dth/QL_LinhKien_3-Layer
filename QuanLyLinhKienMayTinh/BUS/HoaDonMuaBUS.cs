using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BUS
{
    public class HoaDonMuaBUS
    {
        HoaDonMua_funcs hdmDL = new HoaDonMua_funcs();

        public bool kiemtraTrungIdHDMua(string ma)
        {
            return hdmDL.kiemtraTrungIdCTHDMua(ma);
        }

        public bool kiemtraTrungIdCTHDMua(string ma)
        {
            return hdmDL.kiemtraTrungIdCTHDMua(ma);
        }

        public int LaySoLuongTon(string _maLK)
        {
            return hdmDL.LaySoLuongTon(_maLK);
        }

        public DataTable LayDuLieuThamSo()
        {
            return hdmDL.LayDuLieuThamSo();
        }
    }
}
