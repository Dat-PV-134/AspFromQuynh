namespace Phieu1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string username { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string password { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string firstname { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string lastname { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string email { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(30)]
        public string address { get; set; }
    }
}
