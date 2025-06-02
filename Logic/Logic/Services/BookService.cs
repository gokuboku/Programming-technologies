using Library.Data;
using Library.Data.Interfaces;


namespace Library.Logic.Services
{
    public class BookService
    {
        private Repository repo;

        public BookService(Repository repository)
        {
            this.repo = repository;
        }

        public void AddBook(IBook book) => repo.AddBook(book);
        public void RemoveBook(IBook book) => repo.RemoveBook(book);
        public void BorrowBook(IBook book, IUser user) => repo.BorrowBook(book, user);
        public void ReturnBook(IBook book, IUser user) => repo.ReturnBook(book, user);
    }
}
