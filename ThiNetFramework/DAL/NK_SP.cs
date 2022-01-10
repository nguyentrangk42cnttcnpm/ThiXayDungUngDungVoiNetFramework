namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NK_SP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaPhieuNK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public int? SoLuong { get; set; }

        public virtual PhieuNK PhieuNK { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
