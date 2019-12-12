using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Bangcap
    {
        public Bangcap()
        {
            Nhanvien = new HashSet<Nhanvien>();
        }

        public string MaBc { get; set; }
        public string TenBangCap { get; set; }

        public ICollection<Nhanvien> Nhanvien { get; set; }
    }
}
