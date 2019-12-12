using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiLK_funcs
    {
        qlLinhKienLINQDataContext _qllk = new qlLinhKienLINQDataContext();

        public bool kiemTraTrungID(string maLoai)
        {
            var kt = from k in _qllk.LOAI_LKs
                     where k.MaLoai == maLoai
                     select k;
            if (kt.Any())
                return false;
            return true;
        }
    }
}
