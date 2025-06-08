using Data;
using Library.Data;
using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicTests.MockData
{
    internal class MockRepo:IRepository
    {
        private Dictionary<Guid, IBook> Books = new Dictionary<Guid, IBook>();
        private Dictionary<Guid, IUser> Users = new Dictionary<Guid, IUser>();
        private Dictionary<Guid, IEvent> Events = new Dictionary<Guid, IEvent>();
        public MockRepo()
        {

        }

        public void AddBook(IBook book)
        {
            Books[book.Guid] = book;
        }

        public void AddBook(string Title, string Author, string Genre, DateTime PublishedDate, string ISBN, int Pages)
        {
            IBook book = DataFactory.CreateBook(Title, Author, Genre, PublishedDate, ISBN, Pages);
        }

        public void AddUser(IUser user)
        {
            Users[user.Guid] = user;
        }

        public void BorrowBook(IBook book, IUser user)
        {
            if (!Books.ContainsKey(book.Guid)) throw new KeyNotFoundException("Book not found in repository.");
            if (!Users.ContainsKey(user.Guid)) throw new KeyNotFoundException("User not found in repository.");
            book.SetOwner(user.Guid);
        }

        public bool ContainsBook(IBook book)
        {
            return Books.ContainsKey(book.Guid);
        }

        public bool ContainsUser(IUser user)
        {
            return Users.ContainsKey(user.Guid);
        }

        public void Dispose()
        {
            Books.Clear();
            Users.Clear();
            Events.Clear();
        }

        public IEnumerable<IUser> GetAllUsers()
        {
            return Users.Values;
        }

        public IBook GetBook(Guid guid)
        {
            if (Books.TryGetValue(guid, out IBook book))
            {
                return book;
            }
            throw new KeyNotFoundException("Book not found in repository.");
        }

        public IEnumerable<IBook> GetCatalog()
        {
            return Books.Values;
        }

        public ILibraryState GetLibraryState()
        {
            return DataFactory.CreateLibraryState(Books.Values, Users.Values);
        }

        public IEnumerable<IBook> GetNumberOfBooks(int number, int offset)
        {
            return Books.Values.Skip(offset).Take(number);
        }

        public IEnumerable<IUser> GetNumberOfUsers(int number, int offset)
        {
            return Users.Values.Skip(offset).Take(number);
        }

        public IUser GetUser(Guid guid)
        {
            if (Users.TryGetValue(guid, out IUser user))
            {
                return user;
            }
            throw new KeyNotFoundException("User not found in repository.");
        }

        public void RemoveBook(IBook book)
        {
            if (Books.ContainsKey(book.Guid))
            {
                Books.Remove(book.Guid);
            }
            else
            {
                throw new KeyNotFoundException("Book not found in repository.");
            }
        }

        public void RemoveUser(IUser user)
        {
            if (Users.ContainsKey(user.Guid))
            {
                Users.Remove(user.Guid);
            }
            else
            {
                throw new KeyNotFoundException("User not found in repository.");
            }
        }

        public void ReturnBook(IBook book, IUser user)
        {
            if (!Books.ContainsKey(book.Guid)) throw new KeyNotFoundException("Book not found in repository.");
            if (!Users.ContainsKey(user.Guid)) throw new KeyNotFoundException("User not found in repository.");
            book.SetOwner(Guid.Empty); // Set owner to empty Guid to indicate the book is returned
        }

        public void SetFine(IUser user, double amount)
        {
            if (!Users.ContainsKey(user.Guid)) throw new KeyNotFoundException("User not found in repository.");
            user.SetFineAmount(amount);
        }
    }
}
