using Library.Data;
using Library.Data.Interfaces;


namespace Library.Logic.Services
{
    public class BookService
    {
        private Repository repo;

        public BookService(string connectionString)
        {
            this.repo = Repository.Create(connectionString);
        }

        public BookService(Repository repo)
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
