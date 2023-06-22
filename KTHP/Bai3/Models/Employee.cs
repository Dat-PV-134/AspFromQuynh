namespace Bai3.Models
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
        [Required(ErrorMessage = "Mã nhân viên không được để trống!")]
        [DisplayName("Mã nhân viên")]
        public int eid { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Tên nhân viên không được để trống!")]
        [DisplayName("Họ và tên")]
        public string name { get; set; }

        [Required(ErrorMessage = "Tuổi không được để trống!")]
        [DisplayName("Tuổi")]
        public int? age { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        [DisplayName("Địa chỉ")]
        public string addr { get; set; }

        [Required(ErrorMessage = "Lương không được để trống!")]
        [DisplayName("Lương")]
        public int? salary { get; set; }

        [StringLength(50)]
        [DisplayName("Hình ảnh")]
        public string image { get; set; }

        [DisplayName("Phòng ban")]
        public int? deptid { get; set; }

        public virtual Department Department { get; set; }
    }
}
