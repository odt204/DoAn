﻿using System;
using System.Collections.Generic;

namespace WebTrangSuc.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            DonHangs = new HashSet<DonHang>();
        }

        public int MaVoucher { get; set; }
        public int GiaTri { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public bool TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public int? DieuKienApDung { get; set; }
        public int SoLuong { get; set; }

        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
