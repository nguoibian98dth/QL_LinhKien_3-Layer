using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BUS
{
    
    public class ThongKeKinhDoanhBUS
    {
        ThonngKeKinhDoanh_funcs chartKD = new ThonngKeKinhDoanh_funcs();

        //theo năm
        public DataTable layDL_DoanhThuBanTheoNam(int namBC)
        {
            return chartKD.layDL_DoanhThuBanTheoNam(namBC);
        }

        public object laySLBanLKTheoNam(int namBC)
        {
            return chartKD.laySLBanLKTheoNam(namBC);
        }

        public object layTongDoanhThuTheoNam(int namBC)
        {
            return chartKD.layTongDoanhThuTheoNam(namBC);
        }

        public object layTongLoiNhuanTheoNam(int namBC)
        {
            return chartKD.layTongLoiNhuanTheoNam(namBC);
        }

        //theo tháng và năm
        public DataTable layDL_DoanhThuBanTheoThangvaNam(int thangBC, int namBC)
        {
            return chartKD.layDL_DoanhThuBanTheoThangvaNam(thangBC,namBC);
        }

        public object laySLBanLKTheoThangvaNam(int thangBC, int namBC)
        {
            return chartKD.laySLBanLKTheoThangvaNam(thangBC, namBC);
        }

        public object layTongDoanhThuTheoThangvaNam(int thangBC, int namBC)
        {
            return chartKD.layTongDoanhThuTheoThangvaNam(thangBC, namBC);
        }

        public object layTongLoiNhuanTheoThangvaNam(int thangBC, int namBC)
        {
            return chartKD.layTongLoiNhuanTheoThangvaNam(thangBC, namBC);
        }
    }
}
