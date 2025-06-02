namespace Library.Presentation.Model
{
    internal class Book : IBook
    {
        public Guid OwnerId { get; set; }
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime Year { get; set; }
        public Guid Guid { get; set; }
        public int Pages { get; set; }
        public bool IsAvailable { get; set; }
        public void SetAvailability(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }

        public void SetOwnerId(Guid ownerId)
        {
            OwnerId = ownerId;
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
            OwnerId = Guid.Empty;
        }
    }
}
