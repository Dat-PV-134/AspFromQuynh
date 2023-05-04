using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int mark { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string name, string address, int mark)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.mark = mark;
        }
    }
}