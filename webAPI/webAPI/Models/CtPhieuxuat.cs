using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class CtPhieuxuat
    {
        public string MaCtpx { get; set; }
        public string MaPhieuXuat { get; set; }
        public string MaLk { get; set; }
        public int? SoLuong { get; set; }
        public string GhiChu { get; set; }

        public Phieuxuat MaPhieuXuatNavigation { get; set; }
    }
}
