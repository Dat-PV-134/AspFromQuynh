using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai412.Models
{
    public enum loaiTD
    {
        SinhHoat,
        KinhDoanh,
        SanXuat
    }
    public class NguoiTieuDung
    {
        public string name { get; set; }
        public bool hoUuTien { get; set; }
        public loaiTD loaiTT { get; set; }
        public int soCu { get; set; }
        public int soMoi { get; set; }



    }
}