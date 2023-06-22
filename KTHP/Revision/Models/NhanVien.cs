namespace Revision.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        public int MaNV { get; set; }

        [StringLength(30)]
        public string Hoten { get; set; }

        public int? Tuoi { get; set; }

        [StringLength(30)]
        public string Daichi { get; set; }

        public int? Luong { get; set; }

        [StringLength(50)]
        public string image { get; set; }

        public int? Maphong { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
