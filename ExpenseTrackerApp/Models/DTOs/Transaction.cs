using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerApp.Models.DTOs
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal amount { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Note { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
