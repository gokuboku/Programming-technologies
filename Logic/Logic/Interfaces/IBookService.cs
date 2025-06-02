using Library.Data.Interfaces;

namespace Logic.Logic.Interfaces
{
    public interface IBookService
    {
        public void AddBook(IBook book);
        public void RemoveBook(IBook book);
        public void BorrowBook(IBook book, IUser user);
        public void ReturnBook(IBook book, IUser user);
        public IEnumerable<IBook> GetNumberOfBooks(int number, int offset);
    }
}
