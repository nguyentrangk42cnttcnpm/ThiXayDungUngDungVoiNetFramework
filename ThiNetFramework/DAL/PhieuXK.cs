namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuXK")]
    public partial class PhieuXK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuXK()
        {
            XK_SP = new HashSet<XK_SP>();
        }

        [Key]
        [StringLength(50)]
        public string MaPhieuXK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        [StringLength(50)]
        public string MaNV { get; set; }

        public virtual NhanVen NhanVen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XK_SP> XK_SP { get; set; }
    }
}
