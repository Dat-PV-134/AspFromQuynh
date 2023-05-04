using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai421.Models
{
    public enum khuvuc{
        KhuVuaA,
        KhuVuaB,
        KhuVuaC
    }
    public class ThiSinh
    {
        public string name { get; set; }
        public bool chinh { get; set; }
        public khuvuc khuvuc { get; set; }
        public float toan { get; set; }
        public float ly { get; set; }
        public float hoa { get; set; }

    }
}