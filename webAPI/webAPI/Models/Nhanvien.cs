using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            HoadonBanhang = new HashSet<HoadonBanhang>();
            HoadonMuahang = new HashSet<HoadonMuahang>();
            Phieunhap = new HashSet<Phieunhap>();
            Phieuxuat = new HashSet<Phieuxuat>();
        }

        public string MaNv { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string Cmnd { get; set; }
        public string MaBc { get; set; }
        public string GioiTinh { get; set; }

        public Bangcap MaBcNavigation { get; set; }
        public Nguoidung Nguoidung { get; set; }
        public ICollection<HoadonBanhang> HoadonBanhang { get; set; }
        public ICollection<HoadonMuahang> HoadonMuahang { get; set; }
        public ICollection<Phieunhap> Phieunhap { get; set; }
        public ICollection<Phieuxuat> Phieuxuat { get; set; }
    }
}
