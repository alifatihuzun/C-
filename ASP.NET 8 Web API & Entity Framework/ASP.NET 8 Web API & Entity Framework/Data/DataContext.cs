using ASP.NET_8_Web_API___Entity_Framework.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_8_Web_API___Entity_Framework.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().ToTable("BankAccounts");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<BankAccount> BankAccounts { get; set; }  

    }
}
