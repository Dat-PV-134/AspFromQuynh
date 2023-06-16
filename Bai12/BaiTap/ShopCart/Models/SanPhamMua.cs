using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopCart.Models
{
    public class SanPhamMua
    {
        public string masp  { get; set; }
        public int soluong { get; set; }
        public override bool Equals(object obj)
        {
            SanPhamMua spm = (SanPhamMua)obj;
            return (this.masp == spm.masp);
        }

    }
}