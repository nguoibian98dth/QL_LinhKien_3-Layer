using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Phieuxuat
    {
        public Phieuxuat()
        {
            CtPhieuxuat = new HashSet<CtPhieuxuat>();
        }

        public string MaPx { get; set; }
        public string MaHdb { get; set; }
        public string MaKh { get; set; }
        public string MaNv { get; set; }
        public DateTime? NgayXuat { get; set; }

        public HoadonBanhang MaHdbNavigation { get; set; }
        public Nhanvien MaNvNavigation { get; set; }
        public ICollection<CtPhieuxuat> CtPhieuxuat { get; set; }
    }
}
