using Data;
using Library.Data.Interfaces;
using Library.Data.Objects;
using Library.Data.Objects.Events;
using System.Drawing;

namespace Library.Data
{
    public abstract class Repository
    {
        protected LibraryDataContext context;

        private class CRepository : Repository
        {
            public CRepository(string connectionString)
            {
                context = new LibraryDataContext(connectionString);
            }
            public CRepository() 
            { 
            }
        }

        public static Repository Create(string? connectionString = null)
        {
            if (connectionString != null)
            {
                return new CRepository(connectionString);
            }
            return new CRepository();
        }

        private IBook DbToObject(book book)
        {
            if (book == null) return null;
            return new Book(book.Title, book.Author, book.Genre, book.PublishedDate, book.ISBN, book.Pages);
        }

        public void AddBook(string Title, string Author, string Genre, DateTime PublishedDate, string ISBN, int Pages)
        {
            book Book = new book
            {
                Title = Title,
                Author = Author,
                Genre = Genre,
                PublishedDate = PublishedDate,
                ISBN = ISBN,
                Pages = Pages
            };
            event bookEvent = new event
            {
                EventID = ,
                EventDate = DateTime.Now,
                BookGuid = Book.Guid
            };
            context.books.InsertOnSubmit(Book);
            _events.Add(new EventAddBook(Guid.NewGuid(), DateTime.Now, book.Guid));
        }
/*
        public List<IUser> GetAllUsers() => _libraryState.Users;
        public List<IBook> GetCatalog() => _libraryState.Books;
        public ILibraryState GetLibraryState() => _libraryState;
        public List<IEvent> GetEvents() => _events;

        public void AddUser(IUser user)
        {
            _libraryState.Users.Add(user);
            _events.Add(new EventAddUser(Guid.NewGuid(), DateTime.Now, user.Guid));
        }

        public void RemoveUser(IUser user)
        {
            _libraryState.Users.Remove(user);
            _events.Add(new EventRemoveUser(Guid.NewGuid(), DateTime.Now, user.Guid));
        }

        public void RemoveBook(IBook book)
        {
            _libraryState.Books.Remove(book);
            _events.Add(new EventRemoveBook(Guid.NewGuid(), DateTime.Now, book.Guid));
        }

        public void BorrowBook(IBook book, IUser user)
        {
            if (book.IsAvailable)
            {
                book.SetAvailability(false);
                _events.Add(new EventBorrowBook(Guid.NewGuid(), DateTime.Now, book.Guid, user.Guid));
            }
        }

        public void ReturnBook(IBook book, IUser user)
        {
            book.SetAvailability(true);
            _events.Add(new EventReturnBook(Guid.NewGuid(), DateTime.Now, book.Guid, user.Guid));
        }

        public void SetFine(IUser user, double amount)
        {
            user.SetFineAmount(amount);
            _events.Add(new EventSetFine(Guid.NewGuid(), DateTime.Now, user.Guid, amount));
        }
    }
}

