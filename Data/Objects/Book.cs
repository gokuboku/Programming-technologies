using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Interfaces;

namespace Library.Data.Objects
{
    internal class Book : IBook
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime Year { get; set; }
        public Guid Guid { get; set; }
        public int Pages { get; set; }
        public bool IsAvailable { get; set; }
        public Book(string title, string author, string genre, DateTime year, string isbn, int pages)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            Guid = Guid.NewGuid();
            Isbn = isbn;
            Pages = pages;
            IsAvailable = true;
        }
        public void SetAvailability(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }
    }
}
