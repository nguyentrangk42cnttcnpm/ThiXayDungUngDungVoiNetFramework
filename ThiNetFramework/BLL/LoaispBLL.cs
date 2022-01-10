using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiNetFramework.DAL;
using ThiNetFramework.View_Model;

namespace ThiNetFramework.BLL
{
    public enum KETQUA
    {
        ThanhCong, TenTrung
    }
    internal class LoaispBLL
    {
        public static List<LoaiSanPham> GetList()
        {
            QlNoiThatNet model = new QlNoiThatNet();
            return model.LoaiSanPham.OrderByDescending(e => e.TenLoai).ToList();
        }
        public static List<LoaispVM> GetListVM()
        {
            QlNoiThatNet model = new QlNoiThatNet();
            var ls = model.LoaiSanPham.Select(e => new LoaispVM
            {
                MaLoai = e.MaLoai,
                TenLoai = e.TenLoai,
                TotalStudent = e.SanPham.Count
            }).ToList();
            return ls;
        }
        public static void Delete(long idLoaisp)
        {
            QlNoiThatNet model = new QlNoiThatNet();
            var lop = model.LoaiSanPham.Where(e => e.MaLoai == idLoaisp).FirstOrDefault();
            if (lop != null)
                model.LoaiSanPham.Remove(lop);
            else
                throw new Exception("Loại sản phẩm không tồn tại");
            model.SaveChanges();
        }
        public static KETQUA Add(LoaispVM loaispVM)
        {
            QlNoiThatNet model = new QlNoiThatNet();
            var loaisp = model.LoaiSanPham.Where(e => e.TenLoai == loaispVM.TenLoai).FirstOrDefault();
            if (loaisp != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                loaisp = new LoaiSanPham
                {
                    TenLoai = loaispVM.TenLoai
                };
                model.LoaiSanPham.Add(loaisp);
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
        }
        public static KETQUA Update(LoaispVM loaispVM)
        {
            QlNoiThatNet model = new QlNoiThatNet();
            var loaisp = model.LoaiSanPham.Where(e =>
                e.MaLoai != loaispVM.MaLoai && e.TenLoai == loaispVM.TenLoai).FirstOrDefault();
            if (loaisp != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                loaisp = model.LoaiSanPham.Where(e => e.MaLoai == loaispVM.MaLoai).FirstOrDefault();
                loaisp.TenLoai = loaispVM.TenLoai;
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
        }
    }
}
