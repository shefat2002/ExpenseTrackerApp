using ExpenseTrackerApp.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerApp.Models.DBContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        DbSet<Category> Categories { get; set; }
        DbSet<Transaction> Transactions { get; set; }

    }
}
