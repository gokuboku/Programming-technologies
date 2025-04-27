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
        public int Year { get; set; }
        public Guid Guid { get; set; }
        public int Pages { get; set; }
        public bool IsAvailable { get; set; }
        public Book(string title, string author, string genre, int year, string isbn, int pages)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            Guid = Guid.NewGuid();
            Isbn = isbn;
            Pages = pages;
        }
        public void SetAvailability(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }
    }
}
