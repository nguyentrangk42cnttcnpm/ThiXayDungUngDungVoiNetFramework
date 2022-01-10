using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ThiNetFramework.DAL
{
    public partial class QlNoiThatNet : DbContext
    {
        public QlNoiThatNet()
            : base("name=QlNoiThatNet1")
        {
        }

        public virtual DbSet<BangChamCong> BangChamCong { get; set; }
        public virtual DbSet<BangLuong> BangLuong { get; set; }
        public virtual DbSet<ChiTietHD> ChiTietHD { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public virtual DbSet<NK_SP> NK_SP { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhanVen> NhanVen { get; set; }
        public virtual DbSet<PhieuNK> PhieuNK { get; set; }
        public virtual DbSet<PhieuXK> PhieuXK { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<XK_SP> XK_SP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangLuong>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuNK>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuNK>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PhieuNK>()
                .HasMany(e => e.NK_SP)
                .WithRequired(e => e.PhieuNK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuXK>()
                .HasMany(e => e.XK_SP)
                .WithRequired(e => e.PhieuXK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.NK_SP)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.XK_SP)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XK_SP>()
                .Property(e => e.SoLuong)
                .IsFixedLength();
        }
    }
}
