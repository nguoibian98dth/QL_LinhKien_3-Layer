using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class HoadonBanhang
    {
        public HoadonBanhang()
        {
            CtHoadonban = new HashSet<CtHoadonban>();
            Phieuxuat = new HashSet<Phieuxuat>();
        }

        public string MaHd { get; set; }
        public DateTime? NgayLap { get; set; }
        public string MaKh { get; set; }
        public string MaNv { get; set; }
        public decimal? TongTien { get; set; }
        public bool? TinhTrang { get; set; }

        public Khachhang MaKhNavigation { get; set; }
        public Nhanvien MaNvNavigation { get; set; }
        public ICollection<CtHoadonban> CtHoadonban { get; set; }
        public ICollection<Phieuxuat> Phieuxuat { get; set; }
    }
}
