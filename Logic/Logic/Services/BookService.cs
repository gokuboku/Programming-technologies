using Data;
using Library.Data;
using Library.Data.Interfaces;
using Logic.Logic.Interfaces;

namespace Library.Logic.Services
{
    internal class BookService : IBookService
    {
        private IRepository repo;

        public BookService(string connectionString)
        {
            this.repo = DataFactory.CreateRepository(connectionString);
        }

        public BookService(IRepository repo)
        {
            this.repo = repo;
        }

        public void AddBook(IBook book) => repo.AddBook(book);
        public void RemoveBook(IBook book) => repo.RemoveBook(book);
        public void BorrowBook(IBook book, IUser user) => repo.BorrowBook(book, user);
        public void ReturnBook(IBook book, IUser user) => repo.ReturnBook(book, user);
        public IEnumerable<IBook> GetNumberOfBooks(int number, int offset) => repo.GetNumberOfBooks(number, offset);
    }
}
