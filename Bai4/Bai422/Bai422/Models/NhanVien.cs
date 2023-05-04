using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai422.Models
{
    public class NhanVien
    {
        public int Id { get; set; }
        public int Bac { get; set; }
        public int Ngaycong { get; set; }
        public int ChucVu { get; set; }
        public bool GioiTinh { get; set; }
        public bool NgoaiNguAnh { get; set; }
        public bool NgoaiNguPhap { get; set; }
        public bool NgoaiNguNga { get; set; }
    }
}