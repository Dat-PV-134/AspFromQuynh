using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab01.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=EmployeeDB")
        {
        }

        public virtual DbSet<tblDept> tblDepts { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
