﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Marcu_Bogdan_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name="Book Title")]
        [StringLength(150, MinimumLength = 3), Required]
        public String Title { get; set; }
        
        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        public decimal Price { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
        public int? BorrowingID { get; set; }
    }
}
