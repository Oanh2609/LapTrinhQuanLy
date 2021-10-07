using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LapTrinhQuanLy_.Models
{
    public partial class LapTrinhQuanLyDBContext : DbContext
    {
        public LapTrinhQuanLyDBContext()
            : base("name=LapTrinhQuanLyDBContext")
        {
        }
        public virtual DbSet<Employee>  Employees { get; set; }
        public virtual DbSet<Person> People  { get; set; }
        public virtual DbSet<Role> Roles  { get; set; }
        public virtual DbSet<Account> Accounts  { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UseName)
                .IsUnicode(false);
            modelBuilder.Entity<Account>()
                .Property(e => e.PassWord)
                .IsUnicode(true);
        }
    }
}
