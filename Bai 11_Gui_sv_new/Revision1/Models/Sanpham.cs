namespace Revision1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [Key]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống!")]
        [DisplayName("Mã sản phẩm")]
        public int Mavd { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống!")]
        [StringLength(100)]
        [DisplayName("Tên sản phẩm")]
        public string Tenvd { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Mô tả không được để trống!")]
        [DisplayName("Mô tả")]
        public string Mota { get; set; }

        [Required]
        [StringLength(250)]
        [DisplayName("Hình ảnh")]
        public string TenAnh { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống!")]
        [DisplayName("Giá tiền")]
        public decimal Giatien { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trống!")]
        [DisplayName("Số lượng")]
        public int? Soluong { get; set; }


        public int MaDanhmuc { get; set; }

        public virtual Danhmuc Danhmuc { get; set; }
    }
}
