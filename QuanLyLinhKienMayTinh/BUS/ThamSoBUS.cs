using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;
using DAL;

namespace BUS
{
    public class ThamSoBUS
    {

        ThamSo_funcs ts = new ThamSo_funcs();

        public List<THAMSO> GetDLThamSo()
        {
            return ts.GetDLThamSo();
        }

        public DataTable getTS()
        {
            return ts.getTS();
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

        public bool UpdateTS(string mats, int tigia, int muaMax, int tonMax, int tonMin, int banMax)
        {
            try
            {
                ts.UpdateTS(mats, tigia, muaMax, tonMax, tonMin, banMax);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
