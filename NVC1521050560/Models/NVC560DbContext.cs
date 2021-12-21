using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NVC1521050560.Models
{
    public partial class NVC560DbContext : DbContext
    {
        public NVC560DbContext()
            : base("name=NVC560DbContext")
        {
        }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
