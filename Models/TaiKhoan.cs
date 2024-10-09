using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            NguoiDungs = new HashSet<NguoiDung>();
        }

        public int MaTaiKhoan { get; set; }
        public string Email { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public bool VaiTro { get; set; }

        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
