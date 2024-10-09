using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            BaoHanhs = new HashSet<BaoHanh>();
            BinhLuans = new HashSet<BinhLuan>();
            CuocTroChuyenMaKhachHangNavigations = new HashSet<CuocTroChuyen>();
            CuocTroChuyenMaNhanVienNavigations = new HashSet<CuocTroChuyen>();
            DanhGiaSanPhams = new HashSet<DanhGiaSanPham>();
            DonHangs = new HashSet<DonHang>();
            GioHangs = new HashSet<GioHang>();
            HoaDons = new HashSet<HoaDon>();
            SanPhamYeuThiches = new HashSet<SanPhamYeuThich>();
            TinNhanMaNguoiGuiNavigations = new HashSet<TinNhan>();
            TinNhanMaNguoiNhanNavigations = new HashSet<TinNhan>();
        }

        public int MaNguoiDung { get; set; }
        public string TenNguoiDung { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string AnhDaiDien { get; set; } = null!;
        public int MaChucVu { get; set; }
        public int MaTaiKhoan { get; set; }

        public virtual ChucVu MaChucVuNavigation { get; set; } = null!;
        public virtual TaiKhoan MaTaiKhoanNavigation { get; set; } = null!;
        public virtual ICollection<BaoHanh> BaoHanhs { get; set; }
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        public virtual ICollection<CuocTroChuyen> CuocTroChuyenMaKhachHangNavigations { get; set; }
        public virtual ICollection<CuocTroChuyen> CuocTroChuyenMaNhanVienNavigations { get; set; }
        public virtual ICollection<DanhGiaSanPham> DanhGiaSanPhams { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<GioHang> GioHangs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<SanPhamYeuThich> SanPhamYeuThiches { get; set; }
        public virtual ICollection<TinNhan> TinNhanMaNguoiGuiNavigations { get; set; }
        public virtual ICollection<TinNhan> TinNhanMaNguoiNhanNavigations { get; set; }
    }
}
