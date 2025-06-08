using Library.Data.Interfaces;
using Logic.Logic;

namespace Library.Presentation.Model
{
    public static class ModelDataFactory
    {
        public static IRepository CreateRepository(string? connectionString = null)
        {
            return LogicDataFactory.CreateRepository(connectionString);
        }

        public static IBook CreateBook(string title, string author, string genre, DateTime publishedDate, string isbn, int pages)
        {
            return LogicDataFactory.CreateBook(title, author, genre, publishedDate, isbn, pages);
        }

        public static IUser CreateUser(string name, string surname, string email)
        {
            return LogicDataFactory.CreateUser(name, surname, email);
        }

        public static ILibraryState CreateLibraryState(IEnumerable<IBook> books, IEnumerable<IUser> users)
        {
            return LogicDataFactory.CreateLibraryState(books, users);
        }
    }
}
