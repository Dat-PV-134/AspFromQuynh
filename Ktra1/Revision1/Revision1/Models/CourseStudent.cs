using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Revision1.Models
{
    public class CourseStudent
    {
        public Courses course { get; set; }
        public List<Students> students { get; set;}

        public CourseStudent()
        {
            course = new Courses();
            students = new List<Students>();
        }
    }
}