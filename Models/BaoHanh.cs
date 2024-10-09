﻿using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class BaoHanh
    {
        public int MaBaoHanh { get; set; }
        public int MaSanPham { get; set; }
        public int MaNguoiDung { get; set; }
        public DateTime? NgayBaoHanh { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string? MoTa { get; set; }
        public bool TrangThai { get; set; }

        public virtual NguoiDung MaNguoiDungNavigation { get; set; } = null!;
        public virtual SanPham MaSanPhamNavigation { get; set; } = null!;
    }
}
