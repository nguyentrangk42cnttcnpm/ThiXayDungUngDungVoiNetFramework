namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHD = new HashSet<ChiTietHD>();
            NK_SP = new HashSet<NK_SP>();
            XK_SP = new HashSet<XK_SP>();
        }

        public long ID { get; set; }

        [StringLength(50)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        [StringLength(50)]
        public string SoLuong { get; set; }

        [StringLength(50)]
        public string Gia { get; set; }

        public long? MaLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHD { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NK_SP> NK_SP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XK_SP> XK_SP { get; set; }
    }
}
