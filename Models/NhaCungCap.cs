using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaNhaCungCap { get; set; }
        public string TenNhaCungCap { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
