﻿using System.Globalization;

namespace Persistence.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
        public Author Author { get; set; }
    }
}