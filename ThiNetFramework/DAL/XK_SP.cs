namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class XK_SP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaPhieuXK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        public virtual PhieuXK PhieuXK { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
