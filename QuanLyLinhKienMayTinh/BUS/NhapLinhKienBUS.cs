using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using DTO;
using DAL;

namespace BUS
{
    public class NhapLinhKienBUS
    {

        NhapLinhKien_funcs nlkDAL = new NhapLinhKien_funcs();

        // lay ds du lieu hoa don mua va ct hoa don
        public List<HOADON_MUAHANG> LayDSHoaDon_MuaHang()
        {
            return nlkDAL.LayDSHoaDon_MuaHang();
        }

        public int CountHDM()
        {
            return nlkDAL.CountHDM();
        }

        public DataTable getHDM()
        {
            return nlkDAL.getHDM();
        }

        public List<CT_HoaDonMua> LayCT_HoaDonMua(string maHD)
        {
            return nlkDAL.LayCT_HoaDonMua(maHD);
        }

        public bool kiemtraTrungIdPN(string p)
        {
            return nlkDAL.kiemtraTrungIdPN(p);
        }

        public bool kiemtraTrungIdCTPN(string p)
        {
            return nlkDAL.kiemtraTrungIdCTPN(p);
        }

        public void capNhatTinhTrangHDM(string _maHDM)
        {
            nlkDAL.capNhatTinhTrangHDM(_maHDM);
        }

        public string layIdNCC(string _maHDM)
        {
            return nlkDAL.layIdNCC(_maHDM);
        }

        public string layTenNCC(string _maNCC)
        {
            return nlkDAL.layTenNCC(_maNCC);
        }

        public DataTable ToDataTable<T>(IList<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }

            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            //put a breakpoint here and check datatable
            return dataTable;
        }
    }
}
