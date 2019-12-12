using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class HoadonMuahang
    {
        public HoadonMuahang()
        {
            CtHoadonmua = new HashSet<CtHoadonmua>();
            Phieunhap = new HashSet<Phieunhap>();
        }

        public string MaHd { get; set; }
        public DateTime? NgayMua { get; set; }
        public string MaNcc { get; set; }
        public string MaNv { get; set; }
        public decimal? TongTien { get; set; }
        public bool? TinhTrang { get; set; }

        public Nhacungcap MaNccNavigation { get; set; }
        public Nhanvien MaNvNavigation { get; set; }
        public ICollection<CtHoadonmua> CtHoadonmua { get; set; }
        public ICollection<Phieunhap> Phieunhap { get; set; }
    }
}
