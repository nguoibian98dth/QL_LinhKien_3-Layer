using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThonngKeKinhDoanh_funcs
    {
        //theo năm
        DataSQL dtsql = new DataSQL();
        public DataTable layDL_DoanhThuBanTheoNam(int namBC)
        {
            string sql = "select MONTH(NgayLap) as Month,sum(TongTien) as Total_BeforeVAT,sum(TongTien)-(sum(TongTien)/10) as Total_AfterVAT from HOADON_BANHANG where TinhTrang=1 and YEAR(NgayLap)=" + namBC + " group by MONTH(NgayLap)";

            return dtsql.ExecQuery(sql);
        }

        public object laySLBanLKTheoNam(int namBC)
        {
            string sql = "select sum(SoLuong) from HOADON_BANHANG hdb, CT_HOADONBAN ct where YEAR(NgayLap)=" + namBC + " and ct.MaHDB=hdb.MaHD and TinhTrang=1";
            return dtsql.ExecuteScalar(sql);
        }

        public object layTongDoanhThuTheoNam(int namBC)
        {
            string sql = "select sum(TongTien) from HOADON_BANHANG hdb where YEAR(NgayLap)=" + namBC + " and TinhTrang=1";
            return dtsql.ExecuteScalar(sql);
        }

        public object layTongLoiNhuanTheoNam(int namBC)
        {
            string sql = "select sum(TongTien)-(sum(TongTien)/10) from HOADON_BANHANG hdb where YEAR(NgayLap)=" + namBC + " and TinhTrang=1";
            return dtsql.ExecuteScalar(sql);
        }

        //theo tháng và năm
        public DataTable layDL_DoanhThuBanTheoThangvaNam(int thangBC, int namBC)
        {
            string sql = "select day(NgayLap) as DAY,sum(TongTien) as Total_BeforeVAT,sum(TongTien)-(sum(TongTien/10)) as Total_BeforeVAT from HOADON_BANHANG where TinhTrang=1 and MONTH(NgayLap)=" + thangBC + " AND YEAR(NgayLap)=" + namBC + " group by DAY(NgayLap)";

            return dtsql.ExecQuery(sql);
        }

        public object laySLBanLKTheoThangvaNam(int thangBC, int namBC)
        {
            string sql = "select sum(SoLuong) from HOADON_BANHANG hdb, CT_HOADONBAN ct where YEAR(NgayLap)=" + namBC + " and MONTH(NgayLap)=" + thangBC + " and ct.MaHDB=hdb.MaHD and TinhTrang=1";
            return dtsql.ExecuteScalar(sql);
        }

        public object layTongDoanhThuTheoThangvaNam(int thangBC, int namBC)
        {
            string sql = "select sum(TongTien) from HOADON_BANHANG hdb where YEAR(NgayLap)=" + namBC + " and MONTH(NgayLap)=" + thangBC + " and TinhTrang=1";
            return dtsql.ExecuteScalar(sql);
        }

        public object layTongLoiNhuanTheoThangvaNam(int thangBC, int namBC)
        {
            string sql = "select sum(TongTien)-(sum(TongTien/10)) from HOADON_BANHANG hdb where YEAR(NgayLap)=" + namBC + " and MONTH(NgayLap)=" + thangBC + " and TinhTrang=1";
            return dtsql.ExecuteScalar(sql);
        }
    }
}
