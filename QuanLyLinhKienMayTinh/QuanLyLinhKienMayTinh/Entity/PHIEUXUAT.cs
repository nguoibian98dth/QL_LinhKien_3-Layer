//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyLinhKienMayTinh.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUXUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUXUAT()
        {
            this.CT_PHIEUXUAT = new HashSet<CT_PHIEUXUAT>();
        }
    
        public int MaPX { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public Nullable<System.DateTime> NgayXuat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUXUAT> CT_PHIEUXUAT { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
