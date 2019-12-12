using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapLinhKien
    {
        string str_MaPN;
        DateTime str_NgayNhap;
        string str_MaNCC;
        int str_MaNV;

        public string MaPN
        {
            set { str_MaPN = value; }
            get { return str_MaPN; }

        }

        public int MaNV
        {
            set { str_MaNV = value; }
            get { return str_MaNV; }

        }

        public string MaNCC
        {
            set { str_MaNCC = value; }
            get { return str_MaNCC; }

        }

        public DateTime NgayNhap
        {
            set { str_NgayNhap = value; }
            get { return str_NgayNhap; }

        }
    }
}
