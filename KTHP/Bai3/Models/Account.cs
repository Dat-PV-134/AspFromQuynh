namespace Bai3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {

        [Required(ErrorMessage = "Mã tài khoản không được để trống!")]
        [DisplayName("Mã tài khoản")]
        public int id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Têb tài khoản không được để trống!")]
        [DisplayName("Tên tài khoản")]
        public string username { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [DisplayName("Mật khẩu")]
        public string password { get; set; }

        [Required(ErrorMessage = "Phân quyền không được để trống!")]
        [DisplayName("Phân quyền")]
        public byte? role { get; set; }
    }
}
