using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class VatLieu
    {
        public VatLieu()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaVatLieu { get; set; }
        public string TenVatlieu { get; set; } = null!;
        public string? MoTa { get; set; }
        public DateTime NgayTao { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
