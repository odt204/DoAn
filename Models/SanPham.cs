using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            BaoHanhs = new HashSet<BaoHanh>();
            BinhLuans = new HashSet<BinhLuan>();
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            ChiTietGioHangs = new HashSet<ChiTietGioHang>();
            DanhGiaSanPhams = new HashSet<DanhGiaSanPham>();
            KichCos = new HashSet<KichCo>();
            LichSuGiaSanPhams = new HashSet<LichSuGiaSanPham>();
            LichSuGiamGiaSanPhams = new HashSet<LichSuGiamGiaSanPham>();
            MauSacs = new HashSet<MauSac>();
            SanPhamYeuThiches = new HashSet<SanPhamYeuThich>();
        }

        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; } = null!;
        public int GiaTienMoi { get; set; }
        public int GiaTienCu { get; set; }
        public string MoTa { get; set; } = null!;
        public string AnhSp { get; set; } = null!;
        public int MaVatLieu { get; set; }
        public int MaDanhMuc { get; set; }
        public DateTime NgayTao { get; set; }
        public int MaNhaCungCap { get; set; }

        public virtual DanhMuc MaDanhMucNavigation { get; set; } = null!;
        public virtual NhaCungCap MaNhaCungCapNavigation { get; set; } = null!;
        public virtual VatLieu MaVatLieuNavigation { get; set; } = null!;
        public virtual ICollection<BaoHanh> BaoHanhs { get; set; }
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
        public virtual ICollection<DanhGiaSanPham> DanhGiaSanPhams { get; set; }
        public virtual ICollection<KichCo> KichCos { get; set; }
        public virtual ICollection<LichSuGiaSanPham> LichSuGiaSanPhams { get; set; }
        public virtual ICollection<LichSuGiamGiaSanPham> LichSuGiamGiaSanPhams { get; set; }
        public virtual ICollection<MauSac> MauSacs { get; set; }
        public virtual ICollection<SanPhamYeuThich> SanPhamYeuThiches { get; set; }
    }
}
