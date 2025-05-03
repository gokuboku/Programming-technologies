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
            Repository repo = Repository.Create();
            BookService bs = new BookService(repo);
            repo.AddUser(user1);
            repo.AddBook(book1);
            var users = repo.GetAllUsers();
            var cat = repo.GetCatalog();
            var user = users[0];
            var book = cat[0];
            bs.BorrowBook(book, user);
            var evs = repo.GetEvents();
            bool flag = (!cat[0].IsAvailable) && (evs.Last().Action == "BorrowBook");
            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void ReturnBookWorksCorrectly()
        {
            Repository repo = Repository.Create();
            BookService bs = new BookService(repo);
            repo.AddUser(user1);
            repo.AddBook(book1);
            var users = repo.GetAllUsers();
            var cat = repo.GetCatalog();
            var user = users[0];
            var book = cat[0];
            bs.BorrowBook(book, user);
            bs.ReturnBook(book, user);
            var evs = repo.GetEvents();
            bool flag = (cat[0].IsAvailable) && (evs.Last().Action == "ReturnBook");
            Assert.IsTrue(flag);
        }
    }
}
