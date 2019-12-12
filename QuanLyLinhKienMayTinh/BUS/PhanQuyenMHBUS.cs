using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class PhanQuyenMHBUS
    {

        PhanQuyenMH_funcs pqmhDAL = new PhanQuyenMH_funcs();

        public void updateCoQuyen(string mamh, int _maNhom, object quyen)
        {
           pqmhDAL.updateCoQuyen(mamh, _maNhom, quyen);
        }

        public bool kiemTraTrungID(string maMH, int maNhom)
        {
            return pqmhDAL.kiemTraTrungID(maMH, maNhom);
        }
    }
}
