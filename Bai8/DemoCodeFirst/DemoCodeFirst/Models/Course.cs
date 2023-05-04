using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DemoCodeFirst.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Sử dụng antation để tự sinh các mã tự động trogn database
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}