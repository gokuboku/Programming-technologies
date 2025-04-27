using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Data.Interfaces;
using Library.Data.Objects;
using Library.Data.Objects.Events;

namespace Library.Data
{
    internal class Repository: IRepository
    {
        private ILibraryState libraryState = new LibraryState();
        private List<IEvent> events = new();

        public List<IUser> GetAllUsers() => libraryState.Users;
        public List<IBook> GetCatalog() => libraryState.Books;
        public ILibraryState GetLibraryState() => libraryState;
        public List<IEvent> GetEvents() => events;

        public void AddUser(IUser user)
        {
            libraryState.Users.Add(user);
            events.Add(new EventAddUser(Guid.NewGuid(), DateTime.Now, user.Guid));
        }

        public void RemoveUser(IUser user)
        {
            libraryState.Users.Remove(user);
            events.Add(new EventRemoveUser(Guid.NewGuid(), DateTime.Now, user.Guid));
        }

        public void AddBook(IBook book)
        {
            libraryState.Books.Add(book);
            events.Add(new EventAddBook(Guid.NewGuid(), DateTime.Now, book.Guid));
        }

        public void RemoveBook(IBook book)
        {
            libraryState.Books.Remove(book);
            events.Add(new EventRemoveBook(Guid.NewGuid(), DateTime.Now, book.Guid));
        }

        public void BorrowBook(IBook book, IUser user)
        {
            if (book.IsAvailable)
            {
                book.SetAvailability(false);
                events.Add(new EventBorrowBook(Guid.NewGuid(), DateTime.Now, book.Guid, user.Guid));
            }
        }

        public void ReturnBook(IBook book, IUser user)
        {
            book.SetAvailability(true);
            events.Add(new EventReturnBook(Guid.NewGuid(), DateTime.Now, book.Guid, user.Guid));
        }

        public void SetFine(IUser user, double amount)
        {
            user.SetFineAmount(amount);
            events.Add(new EventSetFine(Guid.NewGuid(), DateTime.Now, user.Guid, amount));
        }
    }
}

