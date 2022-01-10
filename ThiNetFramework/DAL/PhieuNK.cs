namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNK")]
    public partial class PhieuNK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNK()
        {
            NK_SP = new HashSet<NK_SP>();
        }

        [Key]
        [StringLength(50)]
        public string MaPhieuNK { get; set; }

        [StringLength(50)]
        public string TenNCC { get; set; }

        [StringLength(50)]
        public string TenSp { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? Gia { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string MaNCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NK_SP> NK_SP { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NhanVen NhanVen { get; set; }
    }
}
