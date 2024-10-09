using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            NguoiDungs = new HashSet<NguoiDung>();
        }

        public int MaChucVu { get; set; }
        public string? TenChucVu { get; set; }

        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
