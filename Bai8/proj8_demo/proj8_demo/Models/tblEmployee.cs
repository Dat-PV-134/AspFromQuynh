namespace proj8_demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEmployee")]
    public partial class tblEmployee
    {
        [Key]
        public int eid { get; set; }

        [Required (ErrorMessage = "Bạn phai nhap ho ten")] // hiển thị bằng tiếng Việt
        [DisplayName("Họ ten")]
        [StringLength(30)]
        public string name { get; set; }

        [Required(ErrorMessage = "Ban phai nhap tuoi")]
        [DisplayName("Tuoi")]
        public int? age { get; set; }

        [Required(ErrorMessage = "Ban phai nhap dia chi")]
        [DisplayName("Dia chi")]
        [StringLength(30)]
        public string addr { get; set; }

        public int? salary { get; set; }

        [StringLength(50)]
        public string image { get; set; }

        public int? deptid { get; set; }

        public virtual tblDept tblDept { get; set; }
    }
}
