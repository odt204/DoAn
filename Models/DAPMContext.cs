using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebTrangSuc.Models
{
    public partial class DAPMContext : DbContext
    {
        public DAPMContext()
        {
        }

        public DAPMContext(DbContextOptions<DAPMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaoHanh> BaoHanhs { get; set; } = null!;
        public virtual DbSet<BinhLuan> BinhLuans { get; set; } = null!;
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; } = null!;
        public virtual DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<CuocTroChuyen> CuocTroChuyens { get; set; } = null!;
        public virtual DbSet<DanhGiaSanPham> DanhGiaSanPhams { get; set; } = null!;
        public virtual DbSet<DanhMuc> DanhMucs { get; set; } = null!;
        public virtual DbSet<DonHang> DonHangs { get; set; } = null!;
        public virtual DbSet<GioHang> GioHangs { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<KichCo> KichCos { get; set; } = null!;
        public virtual DbSet<LichSuGiaSanPham> LichSuGiaSanPhams { get; set; } = null!;
        public virtual DbSet<LichSuGiamGiaSanPham> LichSuGiamGiaSanPhams { get; set; } = null!;
        public virtual DbSet<LichSuTinNhan> LichSuTinNhans { get; set; } = null!;
        public virtual DbSet<MauSac> MauSacs { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SanPhamYeuThich> SanPhamYeuThiches { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<ThanhToan> ThanhToans { get; set; } = null!;
        public virtual DbSet<TinNhan> TinNhans { get; set; } = null!;
        public virtual DbSet<VatLieu> VatLieus { get; set; } = null!;
        public virtual DbSet<Voucher> Vouchers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NFCRPR5;Initial Catalog=DAPM;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoHanh>(entity =>
            {
                entity.HasKey(e => e.MaBaoHanh)
                    .HasName("PK__BaoHanh__A8DF52E5E12D7D87");

                entity.ToTable("BaoHanh");

                entity.Property(e => e.NgayBaoHanh)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.HasOne(d => d.MaNguoiDungNavigation)
                    .WithMany(p => p.BaoHanhs)
                    .HasForeignKey(d => d.MaNguoiDung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BaoHanh__MaNguoi__6383C8BA");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.BaoHanhs)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BaoHanh__MaSanPh__628FA481");
            });

            modelBuilder.Entity<BinhLuan>(entity =>
            {
                entity.HasKey(e => e.MaBinhLuan)
                    .HasName("PK__BinhLuan__87CB66A0C6DE42B0");

                entity.ToTable("BinhLuan");

                entity.Property(e => e.NgayBinhLuan)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaNguoiDungNavigation)
                    .WithMany(p => p.BinhLuans)
                    .HasForeignKey(d => d.MaNguoiDung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BinhLuan__MaNguo__7E37BEF6");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.BinhLuans)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BinhLuan__MaSanP__7D439ABD");
            });

            modelBuilder.Entity<ChiTietDonHang>(entity =>
            {
                entity.HasKey(e => e.MaChiTietDonHang)
                    .HasName("PK__ChiTietD__4B0B45DD6E7F0B65");

                entity.ToTable("ChiTietDonHang");

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaDonHangNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaDonHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietDo__MaDon__787EE5A0");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietDo__MaSan__797309D9");
            });

            modelBuilder.Entity<ChiTietGioHang>(entity =>
            {
                entity.HasKey(e => new { e.MaGioHang, e.MaSanPham })
                    .HasName("PK__ChiTietG__3AAC69E149F9D3B7");

                entity.ToTable("ChiTietGioHang");

                entity.HasOne(d => d.MaGioHangNavigation)
                    .WithMany(p => p.ChiTietGioHangs)
                    .HasForeignKey(d => d.MaGioHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietGi__MaGio__06CD04F7");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.ChiTietGioHangs)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietGi__MaSan__07C12930");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PK__ChucVu__D463953396C1CD89");

                entity.ToTable("ChucVu");

                entity.Property(e => e.TenChucVu).HasMaxLength(30);
            });

            modelBuilder.Entity<CuocTroChuyen>(entity =>
            {
                entity.HasKey(e => e.MaCuocTroChuyen)
                    .HasName("PK__CuocTroC__2E5CA12A23BB2225");

                entity.ToTable("CuocTroChuyen");

                entity.Property(e => e.ThoiGianBatDau)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ThoiGianKetThuc).HasColumnType("datetime");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.CuocTroChuyenMaKhachHangNavigations)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CuocTroCh__MaKha__2DE6D218");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.CuocTroChuyenMaNhanVienNavigations)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CuocTroCh__MaNha__2EDAF651");
            });

            modelBuilder.Entity<DanhGiaSanPham>(entity =>
            {
                entity.HasKey(e => e.MaDanhGia)
                    .HasName("PK__DanhGiaS__AA9515BF5A9C3AC1");

                entity.ToTable("DanhGiaSanPham");

                entity.Property(e => e.NgayDanhGia)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaNguoiDungNavigation)
                    .WithMany(p => p.DanhGiaSanPhams)
                    .HasForeignKey(d => d.MaNguoiDung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DanhGiaSa__MaNgu__1F98B2C1");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.DanhGiaSanPhams)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DanhGiaSa__MaSan__1EA48E88");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.MaDanhMuc)
                    .HasName("PK__DanhMuc__B3750887503AB4E4");

                entity.ToTable("DanhMuc");

                entity.Property(e => e.TenDanhMuc).HasMaxLength(50);
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.HasKey(e => e.MaDonHang)
                    .HasName("PK__DonHang__129584AD0247E11D");

                entity.ToTable("DonHang");

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChiNguoiNhan).HasMaxLength(100);

                entity.Property(e => e.HinhThucNhanHang)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Giao Hang')");

                entity.Property(e => e.NgayDatHang).HasColumnType("date");

                entity.Property(e => e.SdtnguoiNhan)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SDTNguoiNhan")
                    .IsFixedLength();

                entity.Property(e => e.TenNguoiNhan).HasMaxLength(30);

                entity.Property(e => e.TongSl).HasColumnName("TongSL");

                entity.Property(e => e.TrangThai).HasMaxLength(50);

                entity.HasOne(d => d.MaNguoiGuiNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaNguoiGui)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DonHang__MaNguoi__72C60C4A");

                entity.HasOne(d => d.MaVoucherNavigation)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.MaVoucher)
                    .HasConstraintName("FK__DonHang__MaVouch__71D1E811");
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.HasKey(e => e.MaGioHang)
                    .HasName("PK__GioHang__F5001DA3F07BF6DD");

                entity.ToTable("GioHang");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TongTien).HasDefaultValueSql("((0))");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('Chua Thanh Toan')");

                entity.HasOne(d => d.MaNguoiDungNavigation)
                    .WithMany(p => p.GioHangs)
                    .HasForeignKey(d => d.MaNguoiDung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GioHang__MaNguoi__03F0984C");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK__HoaDon__835ED13BC84B38FE");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayXuatHoaDon)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaDonHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaDonHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaDonHan__17F790F9");

                entity.HasOne(d => d.MaNguoiDungNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNguoiDung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaNguoiD__18EBB532");

                entity.HasOne(d => d.MaThanhToanNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaThanhToan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__MaThanhT__19DFD96B");
            });

            modelBuilder.Entity<KichCo>(entity =>
            {
                entity.HasKey(e => e.MaKichCo)
                    .HasName("PK__KichCo__DE76ED87787BEF81");

                entity.ToTable("KichCo");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.KichCos)
                    .HasForeignKey(d => d.MaSanPham)
                    .HasConstraintName("FK__KichCo__MaSanPha__0F624AF8");
            });

            modelBuilder.Entity<LichSuGiaSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLichSu)
                    .HasName("PK__LichSuGi__C443222A161D0365");

                entity.ToTable("LichSuGiaSanPham");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.LichSuGiaSanPhams)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichSuGia__MaSan__367C1819");
            });

            modelBuilder.Entity<LichSuGiamGiaSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLichSuGiamGia)
                    .HasName("PK__LichSuGi__35BD950FF007B79B");

                entity.ToTable("LichSuGiamGiaSanPham");

                entity.Property(e => e.NgayCapNhat)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.LichSuGiamGiaSanPhams)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichSuGia__MaSan__3A4CA8FD");
            });

            modelBuilder.Entity<LichSuTinNhan>(entity =>
            {
                entity.HasKey(e => e.MaLichSu)
                    .HasName("PK__LichSuTi__C443222A4A1D262F");

                entity.ToTable("LichSuTinNhan");

                entity.HasOne(d => d.MaCuocTroChuyenNavigation)
                    .WithMany(p => p.LichSuTinNhans)
                    .HasForeignKey(d => d.MaCuocTroChuyen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichSuTin__MaCuo__32AB8735");

                entity.HasOne(d => d.MaTinNhanNavigation)
                    .WithMany(p => p.LichSuTinNhans)
                    .HasForeignKey(d => d.MaTinNhan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichSuTin__MaTin__31B762FC");
            });

            modelBuilder.Entity<MauSac>(entity =>
            {
                entity.HasKey(e => e.MaMauSac)
                    .HasName("PK__MauSac__B9A9116223CA8C60");

                entity.ToTable("MauSac");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((1))");

                entity.Property(e => e.TenMau).HasMaxLength(50);

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.MauSacs)
                    .HasForeignKey(d => d.MaSanPham)
                    .HasConstraintName("FK__MauSac__MaSanPha__0B91BA14");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.MaNguoiDung)
                    .HasName("PK__NguoiDun__C539D76207CD8C5C");

                entity.ToTable("NguoiDung");

                entity.Property(e => e.AnhDaiDien).IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength();

                entity.Property(e => e.TenNguoiDung).HasMaxLength(50);

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NguoiDungs)
                    .HasForeignKey(d => d.MaChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NguoiDung__MaChu__4F7CD00D");

                entity.HasOne(d => d.MaTaiKhoanNavigation)
                    .WithMany(p => p.NguoiDungs)
                    .HasForeignKey(d => d.MaTaiKhoan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NguoiDung__MaTai__4E88ABD4");
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNhaCungCap)
                    .HasName("PK__NhaCungC__53DA9205CD04FC37");

                entity.ToTable("NhaCungCap");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("SDT")
                    .IsFixedLength();

                entity.Property(e => e.TenNhaCungCap).HasMaxLength(100);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442D5E13E3FD");

                entity.ToTable("SanPham");

                entity.Property(e => e.AnhSp)
                    .IsUnicode(false)
                    .HasColumnName("AnhSP");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenSanPham).HasMaxLength(50);

                entity.HasOne(d => d.MaDanhMucNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaDanhMuc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__MaDanhM__5CD6CB2B");

                entity.HasOne(d => d.MaNhaCungCapNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaNhaCungCap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__MaNhaCu__5DCAEF64");

                entity.HasOne(d => d.MaVatLieuNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaVatLieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__MaVatLi__5BE2A6F2");
            });

            modelBuilder.Entity<SanPhamYeuThich>(entity =>
            {
                entity.HasKey(e => e.MaYeuThich)
                    .HasName("PK__SanPhamY__B9007E4CCB384CBE");

                entity.ToTable("SanPhamYeuThich");

                entity.Property(e => e.NgayThem)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaNguoiDungNavigation)
                    .WithMany(p => p.SanPhamYeuThiches)
                    .HasForeignKey(d => d.MaNguoiDung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPhamYe__MaNgu__245D67DE");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany(p => p.SanPhamYeuThiches)
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPhamYe__MaSan__236943A5");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaTaiKhoan)
                    .HasName("PK__TaiKhoan__AD7C652905BD8EFB");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThanhToan>(entity =>
            {
                entity.HasKey(e => e.MaThanhToan)
                    .HasName("PK__ThanhToa__D4B25844DF26B6F6");

                entity.ToTable("ThanhToan");

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayThanhToan)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhuongThucThanhToan).HasMaxLength(50);

                entity.HasOne(d => d.MaDonHangNavigation)
                    .WithMany(p => p.ThanhToans)
                    .HasForeignKey(d => d.MaDonHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ThanhToan__MaDon__14270015");
            });

            modelBuilder.Entity<TinNhan>(entity =>
            {
                entity.HasKey(e => e.MaTinNhan)
                    .HasName("PK__TinNhan__E5B3062AF6A77094");

                entity.ToTable("TinNhan");

                entity.Property(e => e.DaDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.ThoiGian)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MaNguoiGuiNavigation)
                    .WithMany(p => p.TinNhanMaNguoiGuiNavigations)
                    .HasForeignKey(d => d.MaNguoiGui)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TinNhan__MaNguoi__29221CFB");

                entity.HasOne(d => d.MaNguoiNhanNavigation)
                    .WithMany(p => p.TinNhanMaNguoiNhanNavigations)
                    .HasForeignKey(d => d.MaNguoiNhan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TinNhan__MaNguoi__2A164134");
            });

            modelBuilder.Entity<VatLieu>(entity =>
            {
                entity.HasKey(e => e.MaVatLieu)
                    .HasName("PK__VatLieu__0A1700AC3530975F");

                entity.ToTable("VatLieu");

                entity.Property(e => e.MoTa).HasMaxLength(255);

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenVatlieu).HasMaxLength(100);
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.MaVoucher)
                    .HasName("PK__VOUCHER__0AAC5B111E6E329D");

                entity.ToTable("VOUCHER");

                entity.Property(e => e.DieuKienApDung).HasDefaultValueSql("((0))");

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((1))");

                entity.Property(e => e.ThoiGianBatDau)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ThoiGianKetThuc)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
