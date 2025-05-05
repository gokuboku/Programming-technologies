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
        Repository repo = PredefinedDataGenerator.GeneratePredefinedRepo();

        [TestMethod]
        public void BorrowBookWorksCorrectly()
        {
            BookService bs = new BookService(repo);
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
            BookService bs = new BookService(repo);
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
