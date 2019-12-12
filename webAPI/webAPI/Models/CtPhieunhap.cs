using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class CtPhieunhap
    {
        public string MaCtpn { get; set; }
        public string MaPhieuNhap { get; set; }
        public string MaLk { get; set; }
        public int? SoLuong { get; set; }
        public string GhiChu { get; set; }

        public Linhkien MaLkNavigation { get; set; }
        public Phieunhap MaPhieuNhapNavigation { get; set; }
    }
}
