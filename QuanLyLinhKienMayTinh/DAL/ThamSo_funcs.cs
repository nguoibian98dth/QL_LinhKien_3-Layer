using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace DAL
{
    public class ThamSo_funcs
    {
        qlLinhKienLINQDataContext qllk = new qlLinhKienLINQDataContext();
        DataSQL dtsql = new DataSQL();

        public List<THAMSO> GetDLThamSo()
        {
            return qllk.THAMSOs.Select(ts => ts).ToList<THAMSO>();
        }

        public DataTable getTS()
        {
            string sql_ncc = "select * from ThamSo";
            return dtsql.ExecQuery(sql_ncc);
        }

        public bool UpdateTS(string mats,int tigia, int muaMax, int tonMax,int tonMin, int banMax)
        {
            try
            {
                THAMSO ts = qllk.THAMSOs.Where(t => t.MaTS == mats).FirstOrDefault();
                ts.MaTS = mats;
                ts.TiLeGiaBan = tigia;
                ts.SLMuaToiDa = muaMax;
                ts.SLTonToiDa = tonMax;
                ts.SLTonToiThieu = tonMin;
                ts.SLBanToiDa = banMax;
                qllk.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
