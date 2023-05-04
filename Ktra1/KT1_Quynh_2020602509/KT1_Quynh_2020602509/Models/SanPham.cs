using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KT1_Quynh_2020602509.Models
{
    public class SanPham
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public int soluong { get; set; }
        public float giatien { get; set; }
        public int giamgia { get; set; }

        public double thanhtien()
        {
            if (giamgia == 1)
            {
                return soluong * giatien * 0.9;
            }
            else
            {
                return soluong * giatien;
            }
        }
        public SanPham() { 

        }

        public SanPham(string ma, string ten, int soluong, float giatien, int giamgia)
        {
            this.ma = ma;
            this.ten = ten;
            this.soluong = soluong;
            this.giatien = giatien;
            this.giamgia = giamgia;
        }
    }
}