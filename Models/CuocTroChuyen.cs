using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class CuocTroChuyen
    {
        public CuocTroChuyen()
        {
            LichSuTinNhans = new HashSet<LichSuTinNhan>();
        }

        public int MaCuocTroChuyen { get; set; }
        public int MaKhachHang { get; set; }
        public int MaNhanVien { get; set; }
        public DateTime? ThoiGianBatDau { get; set; }
        public DateTime? ThoiGianKetThuc { get; set; }

        public virtual NguoiDung MaKhachHangNavigation { get; set; } = null!;
        public virtual NguoiDung MaNhanVienNavigation { get; set; } = null!;
        public virtual ICollection<LichSuTinNhan> LichSuTinNhans { get; set; }
    }
}
