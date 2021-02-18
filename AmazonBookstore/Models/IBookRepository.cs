using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Both the repository interface and the implementation of that interface have been created	

namespace AmazonBookstore.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
