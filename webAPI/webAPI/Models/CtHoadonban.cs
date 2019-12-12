using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class CtHoadonban
    {
        public string MaCthd { get; set; }
        public string MaHdb { get; set; }
        public string MaLk { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }

        public HoadonBanhang MaHdbNavigation { get; set; }
        public Linhkien MaLkNavigation { get; set; }
    }
}
