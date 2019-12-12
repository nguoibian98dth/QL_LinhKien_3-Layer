using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Linhkien
    {
        public Linhkien()
        {
            CtHoadonban = new HashSet<CtHoadonban>();
            CtHoadonmua = new HashSet<CtHoadonmua>();
            CtPhieunhap = new HashSet<CtPhieunhap>();
            GiaLk = new HashSet<GiaLk>();
        }

        public string MaLk { get; set; }
        public string TenLk { get; set; }
        public string LoaiLk { get; set; }
        public string NhaSx { get; set; }
        public string XuatXu { get; set; }
        public int? NamSx { get; set; }
        public string MaNcc { get; set; }
        public int? Soluong { get; set; }
        public decimal? GiaNhap { get; set; }

        public LoaiLk LoaiLkNavigation { get; set; }
        public Nhacungcap MaNccNavigation { get; set; }
        public ICollection<CtHoadonban> CtHoadonban { get; set; }
        public ICollection<CtHoadonmua> CtHoadonmua { get; set; }
        public ICollection<CtPhieunhap> CtPhieunhap { get; set; }
        public ICollection<GiaLk> GiaLk { get; set; }
    }
}
