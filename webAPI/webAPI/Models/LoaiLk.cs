using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class LoaiLk
    {
        public LoaiLk()
        {
            Linhkien = new HashSet<Linhkien>();
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string Dvt { get; set; }
        public int? ThangBh { get; set; }

        public ICollection<Linhkien> Linhkien { get; set; }
    }
}
