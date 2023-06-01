namespace qlsp.Models
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
        [Required(ErrorMessage = "Mã sản phẩm không được để trông!")]
        [DisplayName("Mã sản phẩm")]
        public int Mavd { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trông!")]
        [DisplayName("Tên sản phẩm")]
        [StringLength(100)]
        public string Tenvd { get; set; }

        [StringLength(250)]
        public string TenAnh { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trông!")]
        [DisplayName("Mô tả")]
        [StringLength(250)] 
        public string Mota { get; set; }

        [Required(ErrorMessage = "Gía tiền không được để trông!")]
        [DisplayName("Gía tiền")]
        public decimal Giatien { get; set; }

        [Required(ErrorMessage = "Số lượng không được để trông!")]
        [DisplayName("Số lượng")]
        public int? Soluong { get; set; }

        
        [DisplayName("Mã danh mục")]
        public int MaDanhmuc { get; set; }

        public virtual Danhmuc Danhmuc { get; set; }
    }
}
