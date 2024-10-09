using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class DonHang
    {
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            HoaDons = new HashSet<HoaDon>();
            ThanhToans = new HashSet<ThanhToan>();
        }

        public string MaDonHang { get; set; } = null!;
        public DateTime NgayDatHang { get; set; }
        public string TrangThai { get; set; } = null!;
        public double PhiVanChuyen { get; set; }
        public double TongTien { get; set; }
        public int MaNguoiGui { get; set; }
        public string SdtnguoiNhan { get; set; } = null!;
        public string DiaChiNguoiNhan { get; set; } = null!;
        public string TenNguoiNhan { get; set; } = null!;
        public int TongSl { get; set; }
        public int TongSoTien { get; set; }
        public int TienPhaiTra { get; set; }
        public string? HinhThucNhanHang { get; set; }
        public int? MaVoucher { get; set; }

        public virtual NguoiDung MaNguoiGuiNavigation { get; set; } = null!;
        public virtual Voucher? MaVoucherNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
