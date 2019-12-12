using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSo
    {
        String str_MaTS;

        public String MaTS
        {
            get { return str_MaTS; }
            set { str_MaTS = value; }
        }

        int str_TLGiaBan;

        public int TiLeGiaBan
        {
            get { return str_TLGiaBan; }
            set { str_TLGiaBan = value; }
        }

        int str_SLMuaToiDa;

        public int SLMuaToiDa
        {
            get { return str_SLMuaToiDa; }
            set { str_SLMuaToiDa = value; }
        }

        int str_SLTonToiDa;

        public int SLTonToiDa
        {
            get { return str_SLTonToiDa; }
            set { str_SLTonToiDa = value; }
        }

        int str_SLTonToiThieu;

        public int SLTonToiThieu
        {
            get { return str_SLTonToiThieu; }
            set { str_SLTonToiThieu = value; }
        }

        int str_SLBanToiDa;

        public int SLBanToiDa
        {
            get { return str_SLBanToiDa; }
            set { str_SLBanToiDa = value; }
        }
    }
}
