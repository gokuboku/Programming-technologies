using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Data.Objects;
using Library.Data.Objects.Events;

namespace Library.Data.Interfaces
{
    public interface IRepository
    {
        public List<User> GetAllUsers();
        public List<Book> GetCatalog();
        public LibraryState GetLibraryState();
        public List<Event> GetEvents();

        public void AddUser(string name, string surname, string email);
        public void RemoveUser(Guid guid);

        public void AddBook(string title, string author, string genre, int year, string ISBN, int pageCount);
        public void RemoveBook(Guid guid);

        public void BorrowBook(Guid bookGuid, Guid userGuid);
        public void ReturnBook(Guid bookGuid, Guid userGuid);

        public void GiveFine(Guid userGuid, double amount);
        public void PayFine(Guid userGuid, double amount);
    }
}
