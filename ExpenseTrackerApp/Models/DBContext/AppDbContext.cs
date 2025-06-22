using ExpenseTrackerApp.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerApp.Models.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
