using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace webAPI.Models
{
    public partial class QLLinhKienMayTinhContext : DbContext
    {
        public QLLinhKienMayTinhContext()
        {
        }

        public QLLinhKienMayTinhContext(DbContextOptions<QLLinhKienMayTinhContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bangcap> Bangcap { get; set; }
        public virtual DbSet<CtHoadonban> CtHoadonban { get; set; }
        public virtual DbSet<CtHoadonmua> CtHoadonmua { get; set; }
        public virtual DbSet<CtPhieunhap> CtPhieunhap { get; set; }
        public virtual DbSet<CtPhieuxuat> CtPhieuxuat { get; set; }
        public virtual DbSet<GiaLk> GiaLk { get; set; }
        public virtual DbSet<HoadonBanhang> HoadonBanhang { get; set; }
        public virtual DbSet<HoadonMuahang> HoadonMuahang { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Linhkien> Linhkien { get; set; }
        public virtual DbSet<LoaiLk> LoaiLk { get; set; }
        public virtual DbSet<Manhinh> Manhinh { get; set; }
        public virtual DbSet<NdNnd> NdNnd { get; set; }
        public virtual DbSet<Nguoidung> Nguoidung { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcap { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Nhomnguoidung> Nhomnguoidung { get; set; }
        public virtual DbSet<Phanquyen> Phanquyen { get; set; }
        public virtual DbSet<Phieunhap> Phieunhap { get; set; }
        public virtual DbSet<Phieuxuat> Phieuxuat { get; set; }
        public virtual DbSet<Thamso> Thamso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ADMIN;Database =QLLinhKienMayTinh;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bangcap>(entity =>
            {
                entity.HasKey(e => e.MaBc);

                entity.ToTable("BANGCAP");

                entity.Property(e => e.MaBc)
                    .HasColumnName("MaBC")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TenBangCap).HasMaxLength(30);
            });

            modelBuilder.Entity<CtHoadonban>(entity =>
            {
                entity.HasKey(e => e.MaCthd);

                entity.ToTable("CT_HOADONBAN");

                entity.Property(e => e.MaCthd)
                    .HasColumnName("Ma_CTHD")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.MaHdb)
                    .HasColumnName("MaHDB")
                    .HasMaxLength(11);

                entity.Property(e => e.MaLk)
                    .HasColumnName("MaLK")
                    .HasMaxLength(11);

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaHdbNavigation)
                    .WithMany(p => p.CtHoadonban)
                    .HasForeignKey(d => d.MaHdb)
                    .HasConstraintName("FK_CTHOADONBAN_HOADONBANHANG");

                entity.HasOne(d => d.MaLkNavigation)
                    .WithMany(p => p.CtHoadonban)
                    .HasForeignKey(d => d.MaLk)
                    .HasConstraintName("FK_CTHOADONBAN_LINHKIEN");
            });

            modelBuilder.Entity<CtHoadonmua>(entity =>
            {
                entity.HasKey(e => e.MaCthd);

                entity.ToTable("CT_HOADONMUA");

                entity.Property(e => e.MaCthd)
                    .HasColumnName("Ma_CTHD")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.MaHdm)
                    .HasColumnName("MaHDM")
                    .HasMaxLength(11);

                entity.Property(e => e.MaLk)
                    .HasColumnName("MaLK")
                    .HasMaxLength(11);

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaHdmNavigation)
                    .WithMany(p => p.CtHoadonmua)
                    .HasForeignKey(d => d.MaHdm)
                    .HasConstraintName("FK_CTHOADONMUA_HOADONMUAHANG");

                entity.HasOne(d => d.MaLkNavigation)
                    .WithMany(p => p.CtHoadonmua)
                    .HasForeignKey(d => d.MaLk)
                    .HasConstraintName("FK_CTHOADONMUA_LINHKIEN");
            });

            modelBuilder.Entity<CtPhieunhap>(entity =>
            {
                entity.HasKey(e => e.MaCtpn);

                entity.ToTable("CT_PHIEUNHAP");

                entity.Property(e => e.MaCtpn)
                    .HasColumnName("Ma_CTPN")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.MaLk)
                    .HasColumnName("MaLK")
                    .HasMaxLength(11);

                entity.Property(e => e.MaPhieuNhap).HasMaxLength(11);

                entity.HasOne(d => d.MaLkNavigation)
                    .WithMany(p => p.CtPhieunhap)
                    .HasForeignKey(d => d.MaLk)
                    .HasConstraintName("FK_CTPHIEUNHAP_LINHKIEN");

                entity.HasOne(d => d.MaPhieuNhapNavigation)
                    .WithMany(p => p.CtPhieunhap)
                    .HasForeignKey(d => d.MaPhieuNhap)
                    .HasConstraintName("FK_CTPHIEUNHAP_PHIEUNHAP");
            });

            modelBuilder.Entity<CtPhieuxuat>(entity =>
            {
                entity.HasKey(e => e.MaCtpx);

                entity.ToTable("CT_PHIEUXUAT");

                entity.Property(e => e.MaCtpx)
                    .HasColumnName("Ma_CTPX")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.Property(e => e.MaLk)
                    .HasColumnName("MaLK")
                    .HasMaxLength(11);

                entity.Property(e => e.MaPhieuXuat).HasMaxLength(11);

                entity.HasOne(d => d.MaPhieuXuatNavigation)
                    .WithMany(p => p.CtPhieuxuat)
                    .HasForeignKey(d => d.MaPhieuXuat)
                    .HasConstraintName("FK_CTPHIEUXUAT_PHIEUXUAT");
            });

            modelBuilder.Entity<GiaLk>(entity =>
            {
                entity.HasKey(e => new { e.MaLk, e.NgayApDung });

                entity.ToTable("GIA_LK");

                entity.Property(e => e.MaLk)
                    .HasColumnName("MaLK")
                    .HasMaxLength(11);

                entity.Property(e => e.NgayApDung).HasColumnType("date");

                entity.Property(e => e.GiaBan).HasColumnType("money");

                entity.HasOne(d => d.MaLkNavigation)
                    .WithMany(p => p.GiaLk)
                    .HasForeignKey(d => d.MaLk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GIA_LK_LINHKIEN");
            });

            modelBuilder.Entity<HoadonBanhang>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.ToTable("HOADON_BANHANG");

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(11);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NgayLap).HasColumnType("date");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoadonBanhang)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_HOADONBANHANG_KHACHHANG");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HoadonBanhang)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_HOADONBANHANG_NHANVIEN");
            });

            modelBuilder.Entity<HoadonMuahang>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.ToTable("HOADON_MUAHANG");

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaNcc)
                    .HasColumnName("MaNCC")
                    .HasMaxLength(6);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NgayMua).HasColumnType("date");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.HoadonMuahang)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK_HOADONMUAHANG_NHACUNGCAP");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HoadonMuahang)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_HOADONMUAHANG_NHANVIEN");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DienThoai).HasMaxLength(10);

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Linhkien>(entity =>
            {
                entity.HasKey(e => e.MaLk);

                entity.ToTable("LINHKIEN");

                entity.Property(e => e.MaLk)
                    .HasColumnName("MaLK")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.GiaNhap).HasColumnType("money");

                entity.Property(e => e.LoaiLk)
                    .IsRequired()
                    .HasColumnName("LoaiLK")
                    .HasMaxLength(3);

                entity.Property(e => e.MaNcc)
                    .HasColumnName("MaNCC")
                    .HasMaxLength(6);

                entity.Property(e => e.NamSx).HasColumnName("NamSX");

                entity.Property(e => e.NhaSx)
                    .HasColumnName("NhaSX")
                    .HasMaxLength(40);

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.TenLk)
                    .HasColumnName("TenLK")
                    .HasMaxLength(50);

                entity.Property(e => e.XuatXu).HasMaxLength(30);

                entity.HasOne(d => d.LoaiLkNavigation)
                    .WithMany(p => p.Linhkien)
                    .HasForeignKey(d => d.LoaiLk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LINHKIEN_LOAI_LK");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.Linhkien)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK_LINHKIEN_NHACUNGCAP");
            });

            modelBuilder.Entity<LoaiLk>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("LOAI_LK");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.Dvt)
                    .IsRequired()
                    .HasColumnName("DVT")
                    .HasMaxLength(20);

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ThangBh).HasColumnName("ThangBH");
            });

            modelBuilder.Entity<Manhinh>(entity =>
            {
                entity.HasKey(e => e.MaManHinh);

                entity.ToTable("MANHINH");

                entity.Property(e => e.MaManHinh)
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.TenManHinh).HasMaxLength(50);
            });

            modelBuilder.Entity<NdNnd>(entity =>
            {
                entity.HasKey(e => new { e.TaiKhoanNd, e.MaNhomNd });

                entity.ToTable("ND_NND");

                entity.Property(e => e.TaiKhoanNd)
                    .HasColumnName("TaiKhoanND")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.MaNhomNd).HasColumnName("MaNhomND");

                entity.Property(e => e.GhiChu).HasMaxLength(150);

                entity.HasOne(d => d.MaNhomNdNavigation)
                    .WithMany(p => p.NdNnd)
                    .HasForeignKey(d => d.MaNhomNd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ND_NND_NHOMNGUOIDUNG");

                entity.HasOne(d => d.TaiKhoanNdNavigation)
                    .WithMany(p => p.NdNnd)
                    .HasForeignKey(d => d.TaiKhoanNd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ND_NND_NGUOIDUNG");
            });

            modelBuilder.Entity<Nguoidung>(entity =>
            {
                entity.HasKey(e => e.TaiKhoan);

                entity.ToTable("NGUOIDUNG");

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.TaiKhoanNavigation)
                    .WithOne(p => p.Nguoidung)
                    .HasForeignKey<Nguoidung>(d => d.TaiKhoan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NGUOIDUNG_NHANVIEN");
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.HasKey(e => e.MaNcc);

                entity.ToTable("NHACUNGCAP");

                entity.Property(e => e.MaNcc)
                    .HasColumnName("MaNCC")
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DienThoai).HasMaxLength(10);

                entity.Property(e => e.NgayDangKy).HasColumnType("date");

                entity.Property(e => e.SoTaiKhoan).HasMaxLength(15);

                entity.Property(e => e.TenNcc)
                    .HasColumnName("TenNCC")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Cmnd)
                    .HasColumnName("CMND")
                    .HasMaxLength(11);

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DienThoai).HasMaxLength(11);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MaBc)
                    .HasColumnName("MaBC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.HasOne(d => d.MaBcNavigation)
                    .WithMany(p => p.Nhanvien)
                    .HasForeignKey(d => d.MaBc)
                    .HasConstraintName("FK_NHANVIEN_BANGCAP");
            });

            modelBuilder.Entity<Nhomnguoidung>(entity =>
            {
                entity.ToTable("NHOMNGUOIDUNG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TenGoi)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Phanquyen>(entity =>
            {
                entity.HasKey(e => new { e.MaManHinh, e.MaNhomNd });

                entity.ToTable("PHANQUYEN");

                entity.Property(e => e.MaManHinh).HasMaxLength(3);

                entity.Property(e => e.MaNhomNd).HasColumnName("MaNhomND");

                entity.HasOne(d => d.MaManHinhNavigation)
                    .WithMany(p => p.Phanquyen)
                    .HasForeignKey(d => d.MaManHinh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHANQUYEN_MANHINH");

                entity.HasOne(d => d.MaNhomNdNavigation)
                    .WithMany(p => p.Phanquyen)
                    .HasForeignKey(d => d.MaNhomNd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHANQUYEN_NHOMNGUOIDUNG");
            });

            modelBuilder.Entity<Phieunhap>(entity =>
            {
                entity.HasKey(e => e.MaPn);

                entity.ToTable("PHIEUNHAP");

                entity.Property(e => e.MaPn)
                    .HasColumnName("MaPN")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaHdm)
                    .HasColumnName("MaHDM")
                    .HasMaxLength(11);

                entity.Property(e => e.MaNcc)
                    .HasColumnName("MaNCC")
                    .HasMaxLength(6);

                entity.Property(e => e.MaNv)
                    .IsRequired()
                    .HasColumnName("MaNV")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NgayNhap).HasColumnType("date");

                entity.HasOne(d => d.MaHdmNavigation)
                    .WithMany(p => p.Phieunhap)
                    .HasForeignKey(d => d.MaHdm)
                    .HasConstraintName("FK_PHIEUNHAP_HOADON_MUAHANG");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.Phieunhap)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK_PHIEUNHAP_NHACUNGCAP");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Phieunhap)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PHIEUNHAP_NHANVIEN");
            });

            modelBuilder.Entity<Phieuxuat>(entity =>
            {
                entity.HasKey(e => e.MaPx);

                entity.ToTable("PHIEUXUAT");

                entity.Property(e => e.MaPx)
                    .HasColumnName("MaPX")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.MaHdb)
                    .HasColumnName("MaHDB")
                    .HasMaxLength(11);

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(11);

                entity.Property(e => e.MaNv)
                    .HasColumnName("MaNV")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NgayXuat).HasColumnType("date");

                entity.HasOne(d => d.MaHdbNavigation)
                    .WithMany(p => p.Phieuxuat)
                    .HasForeignKey(d => d.MaHdb)
                    .HasConstraintName("FK_PHIEUXUAT_HOADON_BANHANG");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.Phieuxuat)
                    .HasForeignKey(d => d.MaNv)
                    .HasConstraintName("FK_PHIEUXUAT_NHANVIEN");
            });

            modelBuilder.Entity<Thamso>(entity =>
            {
                entity.HasKey(e => e.MaTs);

                entity.ToTable("THAMSO");

                entity.Property(e => e.MaTs)
                    .HasColumnName("MaTS")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.SlbanToiDa).HasColumnName("SLBanToiDa");

                entity.Property(e => e.SlmuaToiDa).HasColumnName("SLMuaToiDa");

                entity.Property(e => e.SltonToiDa).HasColumnName("SLTonToiDa");

                entity.Property(e => e.SltonToiThieu).HasColumnName("SLTonToiThieu");
            });
        }
    }
}
