using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            HoadonBanhang = new HashSet<HoadonBanhang>();
        }

        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public ICollection<HoadonBanhang> HoadonBanhang { get; set; }
    }
}
