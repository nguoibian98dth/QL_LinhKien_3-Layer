using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Phieunhap
    {
        public Phieunhap()
        {
            CtPhieunhap = new HashSet<CtPhieunhap>();
        }

        public string MaPn { get; set; }
        public string MaHdm { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string MaNcc { get; set; }
        public string MaNv { get; set; }

        public HoadonMuahang MaHdmNavigation { get; set; }
        public Nhacungcap MaNccNavigation { get; set; }
        public Nhanvien MaNvNavigation { get; set; }
        public ICollection<CtPhieunhap> CtPhieunhap { get; set; }
    }
}
