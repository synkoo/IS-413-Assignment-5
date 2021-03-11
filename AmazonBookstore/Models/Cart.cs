using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace AmazonBookstore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        //Prepare a storage-aware cart class by applying the virtual keyword

        public virtual void AddItem(Book bo, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == bo.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = bo,
                    Quantity = qty
                });

            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveLine(Book bo) =>
            Lines.RemoveAll(x => x.Book.BookId == bo.BookId);

        public virtual void Clear() => Lines.Clear();

        public decimal ComputeTotalSum() => (decimal)Lines.Sum(e => e.Book.Price * e.Quantity);
           
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
