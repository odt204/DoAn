using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class LichSuTinNhan
    {
        public int MaLichSu { get; set; }
        public int MaTinNhan { get; set; }
        public int MaCuocTroChuyen { get; set; }

        public virtual CuocTroChuyen MaCuocTroChuyenNavigation { get; set; } = null!;
        public virtual TinNhan MaTinNhanNavigation { get; set; } = null!;
    }
}
