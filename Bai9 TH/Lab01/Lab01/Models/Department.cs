namespace Lab01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        [Required(ErrorMessage = "Bạn phải nhập mã bộ phận")]
        [DisplayName("Mã bộ phận")]
        public int deptid { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Bạn phải nhập tên bộ phận")]
        [DisplayName("Bộ phận")]
        public string deptname { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
