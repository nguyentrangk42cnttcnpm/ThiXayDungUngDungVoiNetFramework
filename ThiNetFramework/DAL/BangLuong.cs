namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangLuong")]
    public partial class BangLuong
    {
        [Key]
        [StringLength(50)]
        public string MaBangLuong { get; set; }

        [StringLength(50)]
        public string MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        [StringLength(50)]
        public string Thuong { get; set; }

        [StringLength(50)]
        public string Phat { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTien { get; set; }

        public virtual NhanVen NhanVen { get; set; }
    }
}
