﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerApp.Models.DTOs
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName="nvarchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Type{ get; set; }

    }
}
