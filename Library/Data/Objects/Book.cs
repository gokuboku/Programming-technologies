using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects
{
    public class Book
    {
        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Genre { get; private set; }
        public int Year { get; private set; }
        public Guid GUID { get; private set; }
        public int Pages { get; private set; }
        public bool IsAvailable { get; private set; } = true;

        public Book(string title, string author, string genre, int year, string iSBN, int pages)
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Year = year;
            this.GUID = Guid.NewGuid();
            ISBN = iSBN;
            Pages = pages;
        }

        public void SetAvailability(bool isAvailable)
        {
            this.IsAvailable = isAvailable;
        }
    }
}
