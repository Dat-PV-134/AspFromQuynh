namespace Lab01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Required (ErrorMessage = "Bạn phải nhập mã nhân viên")]
        [DisplayName("Mã nhân viên")]
        public int eid { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Bạn phải nhập họ tên")]
        [DisplayName("Họ tên")]
        public string name { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập tuổi")]
        [DisplayName("Tuổi")]
        public int? age { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Bạn phải nhập địa chỉ")]
        [DisplayName("Địa chỉ")]
        public string address { get; set; }

        [Required(ErrorMessage = "Bạn phải nhập lương")]
        [DisplayName("Lương")]
        public int? salary { get; set; }

        [StringLength(50)]
        [DisplayName("Hình ảnh")]
        public string image { get; set; }

        public int? deptid { get; set; }

        public virtual Department Department { get; set; }
    }
}
