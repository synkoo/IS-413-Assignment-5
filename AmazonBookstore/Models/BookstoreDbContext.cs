using System;
using Microsoft.EntityFrameworkCore;

//DBContext File has been created	

namespace AmazonBookstore.Models
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base (options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
