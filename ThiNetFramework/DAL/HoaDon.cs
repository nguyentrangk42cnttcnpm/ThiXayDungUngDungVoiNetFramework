namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHD = new HashSet<ChiTietHD>();
        }

        [Key]
        [StringLength(50)]
        public string MaHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [StringLength(50)]
        public string MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHD { get; set; }

        public virtual NhanVen NhanVen { get; set; }
    }
}
