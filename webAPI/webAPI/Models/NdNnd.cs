using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class NdNnd
    {
        public string TaiKhoanNd { get; set; }
        public int MaNhomNd { get; set; }
        public string GhiChu { get; set; }

        public Nhomnguoidung MaNhomNdNavigation { get; set; }
        public Nguoidung TaiKhoanNdNavigation { get; set; }
    }
}
