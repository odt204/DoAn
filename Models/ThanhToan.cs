using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class ThanhToan
    {
        public ThanhToan()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaThanhToan { get; set; }
        public string MaDonHang { get; set; } = null!;
        public string PhuongThucThanhToan { get; set; } = null!;
        public DateTime? NgayThanhToan { get; set; }
        public double TongTien { get; set; }
        public bool TrangThaiThanhToan { get; set; }

        public virtual DonHang MaDonHangNavigation { get; set; } = null!;
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
