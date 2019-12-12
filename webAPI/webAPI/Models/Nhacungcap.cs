using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Nhacungcap
    {
        public Nhacungcap()
        {
            HoadonMuahang = new HashSet<HoadonMuahang>();
            Linhkien = new HashSet<Linhkien>();
            Phieunhap = new HashSet<Phieunhap>();
        }

        public string MaNcc { get; set; }
        public string TenNcc { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string SoTaiKhoan { get; set; }
        public DateTime? NgayDangKy { get; set; }

        public ICollection<HoadonMuahang> HoadonMuahang { get; set; }
        public ICollection<Linhkien> Linhkien { get; set; }
        public ICollection<Phieunhap> Phieunhap { get; set; }
    }
}
