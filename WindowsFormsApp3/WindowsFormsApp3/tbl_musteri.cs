//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp3
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_musteri()
        {
            this.tbl_kiralama = new HashSet<tbl_kiralama>();
        }
    
        public int id { get; set; }
        public Nullable<int> arac_id { get; set; }
        public string tc { get; set; }
        public string adi_soyadi { get; set; }
        public string cinsiyet { get; set; }
        public string telefon { get; set; }
        public string dogum_tarihi { get; set; }
        public string ehliyet_no { get; set; }
        public string sifre { get; set; }
    
        public virtual tbl_arac tbl_arac { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_kiralama> tbl_kiralama { get; set; }
    }
}
