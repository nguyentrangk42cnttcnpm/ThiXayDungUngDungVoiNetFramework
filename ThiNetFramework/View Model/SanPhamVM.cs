using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiNetFramework.DAL;

namespace ThiNetFramework.View_Model
{
    public class SanPhamVM
    {
        public long ID { get; set; }
        public string MaSP { get; set; }
        public string Tensp { get; set; }
        public string soluong { get; set; }
        public string gia { get; set; }
        public long? MaLoai { get; set; }

        [ForeignKey("MaLoai")]
        public virtual LoaiSanPham Loaisp { get; set; }

    }
}
