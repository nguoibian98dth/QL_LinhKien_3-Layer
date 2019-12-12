using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhomQuyen_funcs
    {
        qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();

        public bool kiemTraTrungID(int maNhom)
        {
            var kt = from k in _qllk.NHOMNGUOIDUNGs
                     where k.ID == maNhom
                     select k;
            if (kt.Any())
                return false;
            return true;
        }

        public bool capNhatNhomQuyen(int maNhom, string tenNhom)
        {
            try
            {
                NHOMNGUOIDUNG nnd = new NHOMNGUOIDUNG();
                nnd = _qllk.NHOMNGUOIDUNGs.Where(t => t.ID == maNhom).FirstOrDefault();
                if (nnd != null)
                {
                    nnd.TenGoi = tenNhom;
                    _qllk.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
         
    }
}
