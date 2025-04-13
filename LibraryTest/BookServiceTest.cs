using Library.Data;
using Library.Data.Objects;
using Library.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    [TestClass]
    public class BookServiceTest
    {
        User user1 = new User("John", "Pork", "jpork@email.com");
        Book book1 = new Book("1984", "George Orwell", "Dystopian", 1949, "978-0451524935", 328);

        [TestMethod]
        public void BorrowBookWorksCorrectly()
        {
            Repository repo = new Repository();
            BookService bs = new BookService(repo);
            repo.AddUser(user1);
            repo.AddBook(book1);
            bs.BorrowBook(book1.GUID, user1.GUID);
            var cat = repo.GetCatalog();
            var evs = repo.GetEvents();
            bool flag = (!cat[0].IsAvailable) && (evs.Last().Action == "Book_borrowed");
            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void ReturnBookWorksCorrectly()
        {
            Repository repo = new Repository();
            BookService bs = new BookService(repo);
            repo.AddUser(user1);
            repo.AddBook(book1);
            bs.BorrowBook(book1.GUID, user1.GUID);
            bs.ReturnBook(book1.GUID, user1.GUID);
            var cat = repo.GetCatalog();
            var evs = repo.GetEvents();
            bool flag = (cat[0].IsAvailable) && (evs.Last().Action == "Book_returned");
            Assert.IsTrue(flag);
        }
    }
}
