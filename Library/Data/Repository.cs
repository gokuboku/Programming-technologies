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
    public class Repository: IRepository
    {
        private LibraryState libraryState = new();
        private List<Event> events = new();


        public IEnumerable<User> GetAllUsers() => libraryState.Users;
        public IEnumerable<Book> GetCatalog() => libraryState.Books;
        public LibraryState GetLibraryState() => libraryState;
        public IEnumerable<Event> GetEvents() => events;

        public void AddUser(string name, string surname, string email)
        {
            User user = new(name, surname, email);
            libraryState.Users.Append(user);
            events.Add(new EventAddUser(user.GUID, DateTime.Now));
        }
        public void RemoveUser(Guid guid)
        {
            var user = libraryState.Users.FirstOrDefault(u => u.GUID == guid);
            if (user != null)
            {
                libraryState.Users.Remove(user);
                events.Add(new EventRemoveUser(user.GUID, DateTime.Now));
            }
        }

        public void AddBook(string title, string author, string genre, int year, string ISBN, int pageCount)
        {
            Book book = new(title, author, genre, year, ISBN, pageCount);
            libraryState.Books.Append(book);
            events.Add(new EventAddBook(book.GUID, DateTime.Now));
        }
        public void RemoveBook(Guid guid)
        {
            var book = libraryState.Books.FirstOrDefault(b => b.GUID == guid);
            if (book != null)
            {
                libraryState.Books.Remove(book);
                events.Add(new EventRemoveBook(book.GUID, DateTime.Now));
            }
        }

        public void BorrowBook(Guid bookGuid, Guid userGuid)
        {
            var book = libraryState.Books.FirstOrDefault(b => b.GUID == bookGuid);
            var user = libraryState.Users.FirstOrDefault(u => u.GUID == userGuid);
            if (book != null && user != null && book.IsAvailable)
            {
                book.SetAvailability(false);
                events.Add(new EventBorrowBook(book.GUID, user.GUID, DateTime.Now));
            }
        }
        public void ReturnBook(Guid bookGuid, Guid userGuid)
        {
            var book = libraryState.Books.FirstOrDefault(b => b.GUID == bookGuid);
            var user = libraryState.Users.FirstOrDefault(u => u.GUID == userGuid);
            if (book != null && user != null && !book.IsAvailable)
            {
                book.SetAvailability(true);
                events.Add(new EventReturnBook(book.GUID, user.GUID, DateTime.Now));
            }
        }

        public void GiveFine(Guid userGuid, double amount)
        {
            var user = libraryState.Users.FirstOrDefault(u => u.GUID == userGuid);
            if (user != null)
            {
                user.SetFineAmount(user.FineAmount + amount);
                events.Add(new EventSetFine("Fine_Given",user.GUID, DateTime.Now, amount));
            }
        }
        public void PayFine(Guid userGuid, double amount)
        {
            var user = libraryState.Users.FirstOrDefault(u => u.GUID == userGuid);
            if (user != null)
            {
                user.SetFineAmount(user.FineAmount - amount);
                events.Add(new EventSetFine("Fine_Paid", user.GUID, DateTime.Now, -amount));
            }
        }
    }
}

