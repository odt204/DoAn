using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class TinNhan
    {
        public TinNhan()
        {
            LichSuTinNhans = new HashSet<LichSuTinNhan>();
        }

        public int MaTinNhan { get; set; }
        public int MaNguoiGui { get; set; }
        public int MaNguoiNhan { get; set; }
        public string NoiDung { get; set; } = null!;
        public DateTime? ThoiGian { get; set; }
        public bool? DaDoc { get; set; }

        public virtual NguoiDung MaNguoiGuiNavigation { get; set; } = null!;
        public virtual NguoiDung MaNguoiNhanNavigation { get; set; } = null!;
        public virtual ICollection<LichSuTinNhan> LichSuTinNhans { get; set; }
    }
}
