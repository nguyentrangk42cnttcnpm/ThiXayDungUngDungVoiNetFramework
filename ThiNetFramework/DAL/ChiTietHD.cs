namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHD")]
    public partial class ChiTietHD
    {
        [Key]
        [StringLength(50)]
        public string MaCTHD { get; set; }

        [StringLength(50)]
        public string TenSp { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string MaHD { get; set; }

        public long? ID { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
