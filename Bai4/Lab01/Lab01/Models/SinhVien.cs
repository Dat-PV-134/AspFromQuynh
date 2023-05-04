using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01.Models
{
    public class SinhVien
    {
        public string Id { get; set; }
        public string Name  {get; set; }
        public double Marks { get; set; }

        public SinhVien(){}

        public SinhVien(string id, string name, float marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }
    }
}