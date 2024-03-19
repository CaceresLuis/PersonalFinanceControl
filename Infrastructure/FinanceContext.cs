using Microsoft.EntityFrameworkCore;
using PersonalFinanceControl.Models;

namespace PersonalFinanceControl.Infrastructure
{
    public class FinanceContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={Connection.GetRoute("PersonalFinance")}");
        }
    }
}
