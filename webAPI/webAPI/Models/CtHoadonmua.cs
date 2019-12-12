using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class CtHoadonmua
    {
        public string MaCthd { get; set; }
        public string MaHdm { get; set; }
        public string MaLk { get; set; }
        public int? SoLuong { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? ThanhTien { get; set; }

        public HoadonMuahang MaHdmNavigation { get; set; }
        public Linhkien MaLkNavigation { get; set; }
    }
}
