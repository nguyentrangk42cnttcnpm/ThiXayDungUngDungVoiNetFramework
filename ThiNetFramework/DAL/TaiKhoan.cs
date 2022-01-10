namespace ThiNetFramework.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(50)]
        public string TenDN { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string Quyen { get; set; }

        [StringLength(50)]
        public string MaNV { get; set; }

        public virtual NhanVen NhanVen { get; set; }
    }
}
