using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;


namespace BUS
{
    public class BaoCaoBanHangBUS
    {
        BaoCaoBanHang_funcs bc = new BaoCaoBanHang_funcs();

        public  DataTable layDuLieuBXH_LK()
        {
            return bc.layDuLieuBXH_LK();
        }

        public  DataTable layDuLieuBXH_NV()
        {
            return bc.layDuLieuBXH_NV();
        }

        public  DataTable layDuLieuHDB()
        {
            return bc.layDuLieuHDB();
        }
    }
}
