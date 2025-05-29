using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Interfaces;

namespace Library.Presentation.Model
{
    internal class Book : IBook
    {
        public Guid Owner { get; set; }
        public string Isbn { get; }
        public string Title { get; }
        public string Author { get; }
        public string Genre { get; }
        public DateTime Year { get; }
        public Guid Guid { get; }
        public int Pages { get; }
        public bool IsAvailable { get; }
        public void SetAvailability(bool isAvailable)
        {
            throw new NotImplementedException();
        }

        public Book(string isbn, string title, string author, string genre, DateTime year, Guid guid, int pages)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            Guid = guid;
            Pages = pages;
            IsAvailable = true;
            Owner = Guid.Empty;
        }
    }
}
