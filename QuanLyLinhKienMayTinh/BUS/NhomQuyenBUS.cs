using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class NhomQuyenBUS
    {
        NhomQuyen_funcs nqDAL = new NhomQuyen_funcs();

        public bool kiemTraTrungID(int maNhom)
        {
            return nqDAL.kiemTraTrungID(maNhom);
        }

        public bool capNhatNhomQuyen(int maNhom, string tenNhom)
        {
            try
            {
                nqDAL.capNhatNhomQuyen(maNhom, tenNhom);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
