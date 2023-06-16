using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopCart.Models
{
    public class SanPham
    {
        public string masp { get; set; }
        public string tensp { get; set; }
        public string hinhanh { get; set; }
        public int giatien { get; set; }

        public SanPham()
        {
            
        }
        public SanPham(string masp)
        {
            this.masp = masp;
        }
        public SanPham(string masp, string tensp, string hinhanh, int giatien)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.hinhanh = hinhanh;
            this.giatien = giatien;
        }
        public override bool Equals(object obj)
        {
            SanPham sp = (SanPham)obj;
            return (this.masp == sp.masp) ;
        }
    }
}