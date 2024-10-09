using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class GioHang
    {
        public GioHang()
        {
            ChiTietGioHangs = new HashSet<ChiTietGioHang>();
        }

        public int MaGioHang { get; set; }
        public int MaNguoiDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? TrangThai { get; set; }
        public double? TongTien { get; set; }

        public virtual NguoiDung MaNguoiDungNavigation { get; set; } = null!;
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
    }
}
