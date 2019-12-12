using System;
using System.Collections.Generic;

namespace webAPI.Models
{
    public partial class Manhinh
    {
        public Manhinh()
        {
            Phanquyen = new HashSet<Phanquyen>();
        }

        public string MaManHinh { get; set; }
        public string TenManHinh { get; set; }

        public ICollection<Phanquyen> Phanquyen { get; set; }
    }
}
