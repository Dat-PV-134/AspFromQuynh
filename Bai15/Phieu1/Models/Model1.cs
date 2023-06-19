using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Phieu1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.password)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.firstname)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.lastname)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.email)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.address)
                .IsFixedLength();
        }
    }
}
