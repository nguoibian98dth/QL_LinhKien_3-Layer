using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanQuyenMH_funcs
    {
  
        qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();

        public void updateCoQuyen(string mamh, int _maNhom, object quyen)
        {
            //update for LINQ
            PHANQUYEN pq = new PHANQUYEN();
            pq = _qllk.PHANQUYENs.Where(t => t.MaManHinh == mamh && t.MaNhomND == _maNhom).FirstOrDefault();
            if (pq != null)
            {
                pq.CoQuyen = Convert.ToBoolean(quyen);
                _qllk.SubmitChanges();
            }
        }

        public bool kiemTraTrungID(string maMH, int maNhom)
        {
            var kt = from k in _qllk.PHANQUYENs
                     where k.MaManHinh == maMH && k.MaNhomND == maNhom
                     select k;

            if (kt.Any())
                return false;
            return true;
        }
    }
}
