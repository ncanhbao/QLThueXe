//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOPDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONG()
        {
            this.CHITIETHOPDONGs = new HashSet<CHITIETHOPDONG>();
            this.HOADONTTs = new HashSet<HOADONTT>();
            this.SOXEs = new HashSet<SOXE>();
        }
    
        public string SoHD { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> MaKhach { get; set; }
        public string NDCongViec { get; set; }
        public string TrachNhiem { get; set; }
        public string DonGia_HTTT { get; set; }
        public string DKCuThe { get; set; }
        public string DKChung { get; set; }
        public Nullable<decimal> TienTamUng { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOPDONG> CHITIETHOPDONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONTT> HOADONTTs { get; set; }
        public virtual KHACH KHACH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOXE> SOXEs { get; set; }
    }
}