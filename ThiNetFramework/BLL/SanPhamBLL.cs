using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiNetFramework.DAL;
using ThiNetFramework.View_Model;

namespace ThiNetFramework.BLL
{
    public enum kq
    {
        ThanhCong, matrung
    }
    internal class SanPhamBLL
    {
        public static List<SanPham> GetList(long idLoaisp)
        {
            QlNoiThatNet model = new QlNoiThatNet();
            return model.SanPham.Where(e => e.MaLoai == idLoaisp).ToList();
        }
        public static List<SanPhamVM> GetListVM()
        {
            QlNoiThatNet model = new QlNoiThatNet();
            var ls = model.SanPham.Select(e => new SanPhamVM
            {
                ID = e.ID,
                MaSP = e.MaSP,
                Tensp = e.TenSP,
                soluong = e.SoLuong,
                gia = e.Gia,
                MaLoai = e.MaLoai,
            }).ToList();
            return ls;
        }
        public static void Delete(long idsanpham)
        {
            QlNoiThatNet model = new QlNoiThatNet();
            var sanpham = model.SanPham.Where(e => e.ID == idsanpham).FirstOrDefault();
            if (sanpham != null)
                model.SanPham.Remove(sanpham);
            else
                throw new Exception("Không có sản phẩm nào");
            model.SaveChanges();
        }
        public static kq Add(SanPhamVM sanphamVM)
        {
            QlNoiThatNet model = new QlNoiThatNet();
            var sanpham = model.SanPham.Where(e => e.MaSP == sanphamVM.MaSP).FirstOrDefault();
            if (sanpham != null)
            {
                return kq.matrung;
            }
            else
            {
                sanpham = new SanPham
                {
                    MaSP = sanphamVM.MaSP,
                    TenSP = sanphamVM.Tensp,
                    SoLuong = sanphamVM.soluong,
                    Gia = sanphamVM.gia,
                    MaLoai = (long)sanphamVM.MaLoai
                };
                model.SanPham.Add(sanpham);
                model.SaveChanges();
                return kq.ThanhCong;
            }
        }
        public static kq Update(SanPhamVM sanphamVM)
        {
            QlNoiThatNet model = new QlNoiThatNet();
            var sanpham = model.SanPham.Where(e => e.ID != sanphamVM.ID &&
                e.MaSP != sanphamVM.MaSP).FirstOrDefault();
            if (sanpham != null)
            {
                return kq.matrung;
            }
            else
            {
                sanpham = model.SanPham.Where(e => e.ID == sanphamVM.ID).FirstOrDefault();              
                sanpham.TenSP = sanphamVM.Tensp;
                sanpham.SoLuong = sanphamVM.soluong;
                sanpham.Gia = sanphamVM.gia;
                sanpham.MaLoai = (long)sanphamVM.MaLoai;
                model.SaveChanges();
                return kq.ThanhCong;
            }
        }
    }
}

