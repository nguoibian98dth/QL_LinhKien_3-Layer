using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Phanquyen
    {
        public string MaManHinh { get; set; }
        public int MaNhomNd { get; set; }
        public bool CoQuyen { get; set; }

        public Manhinh MaManHinhNavigation { get; set; }
        public Nhomnguoidung MaNhomNdNavigation { get; set; }
    }
}
