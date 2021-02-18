using System;
using System.ComponentModel.DataAnnotations;

namespace AmazonBookstore.Models
{
    public class Book
    {
        public Book()
        {
        }

        //All properties are required. (Other than Middle Initial)

        //Establish Primary Key
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirst { get; set; }

#nullable enable
        public string? AuthorMiddle { get; set; }
#nullable disable

        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public string Publisher { get; set; }

        //ISBN Validation
        [Required, RegularExpression(@"^\d{3}-\d{10}$")]
        public string ISBN { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
