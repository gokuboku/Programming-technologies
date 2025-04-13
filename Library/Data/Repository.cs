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

        }
        public void RemoveUser(Guid guid)
        {

        }

        public void AddBook(string title, string author, string genre, int year)
        {

        }
        public void RemoveBook(Guid guid)
        {

        }

        public void BorrowBook(Guid bookGuid, Guid userGuid)
        {

        }
        public void ReturnBook(Guid bookGuid, Guid userGuid)
        {

        }

        public void GiveFine(Guid userGuid, double amount)
        {

        }
        public void PayFine(Guid userGuid, double amount)
        {

        }
    }
}

