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
        public List<IUser> GetAllUsers();
        public List<IBook> GetCatalog();
        public ILibraryState GetLibraryState();
        public List<IEvent> GetEvents();

        public void AddUser(IUser user);
        public void RemoveUser(IUser user);

        public void AddBook(IBook book);
        public void RemoveBook(IBook book);

        public void BorrowBook(IBook book, IUser user);
        public void ReturnBook(IBook book, IUser user);

        public void GiveFine(IUser user, double amount);
        public void PayFine(IUser user, double amount);
    }
}
