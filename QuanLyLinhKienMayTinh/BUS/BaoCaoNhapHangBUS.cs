
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BaoCaoNhapHangBUS
    {
        BaoCaoNhapHang_funcs nh = new BaoCaoNhapHang_funcs();
        public  DataTable GetSoLanDat()
        {
            return nh.GetSoLanDat();
        }

        public DataTable GetLKnhapnhieu()
        {
            return nh.GetLKnhapnhieu();
        }

    }
}
