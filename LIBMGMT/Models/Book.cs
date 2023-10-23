using System;
using System.Collections.Generic;

using LIBMGMT.Interfaces;
namespace LIBMGMT.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string? Name { get; set; }

        public int? PageCount { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; } = null!;

        public virtual ICollection<Borrow> Borrows { get; } = new List<Borrow>();
    }
}
