namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BangChamCong")]
    public partial class BangChamCong
    {
        [Key]
        [StringLength(50)]
        public string MaBCC { get; set; }

        [StringLength(50)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string TongNgayLam { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual NhanVen NhanVen { get; set; }
    }
}
