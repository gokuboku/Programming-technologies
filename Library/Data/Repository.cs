using Library.Data.Interfaces;
using Library.Data.Objects;
using Library.Data.Objects.Events;

namespace Library.Data
{
    public abstract class Repository
    {
        private class CRepository : Repository
        {
            public CRepository(Repository repo)
            {
                _libraryState = repo._libraryState;
                _events = repo._events;
            }
            public CRepository() { }
        }

        public static Repository Create(Repository? repo = null)
        {
            if (repo != null)
            {
                return new CRepository(repo);
            }
            return new CRepository();
        }

        private ILibraryState _libraryState = new LibraryState();
        private List<IEvent> _events = [];

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

        public void AddBook(IBook book)
        {
            _libraryState.Books.Add(book);
            _events.Add(new EventAddBook(Guid.NewGuid(), DateTime.Now, book.Guid));
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

