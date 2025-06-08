using Data;
using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public static class LogicDataFactory
    {
        public static IRepository CreateRepository(string? connectionString = null)
        {
            return DataFactory.CreateRepository(connectionString);
        }

        public static IBook CreateBook(string title, string author, string genre, DateTime publishedDate, string isbn, int pages)
        {
            return DataFactory.CreateBook(title, author, genre, publishedDate, isbn, pages);
        }

        public static IUser CreateUser(string name, string surname, string email)
        {
            return DataFactory.CreateUser(name, surname, email);
        }

        public static ILibraryState CreateLibraryState(IEnumerable<IBook> books, IEnumerable<IUser> users)
        {
            return DataFactory.CreateLibraryState(books, users);
        }
    }
}
