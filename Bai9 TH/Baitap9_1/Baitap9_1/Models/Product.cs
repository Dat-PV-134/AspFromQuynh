namespace Baitap9_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Required(ErrorMessage ="Bạn  phải nhập mã rượu")]
        [DisplayName("Mã rượu")]
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Tên rượu")]
        public string ProductName { get; set; }

        [Column(TypeName = "text")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayName("Giá nhập")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayName("Giá bán")]
        public decimal Price { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [StringLength(20)]
        [DisplayName("Năm sản xuất")]
        public string Vintage { get; set; }

        [Required (ErrorMessage ="Không được để trống")]
        [StringLength(10)]
        [DisplayName("Năm sản xuất")]
        public string CatalogyID { get; set; }

        [Column(TypeName = "text")]
        [DisplayName("Hỉnh ảnh")]
        public string Image { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Vùng")]
        public string Region { get; set; }

        public virtual Catalogy Catalogy { get; set; }
    }
}
