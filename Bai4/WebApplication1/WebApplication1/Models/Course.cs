using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Course
    {
        public int courseId { get; set; }

        public string name { get; set; }

        public Course()
        {

        }

        public Course(int courseId, string name)
        {
            this.courseId = courseId;
            this.name = name;
        }
    }
}