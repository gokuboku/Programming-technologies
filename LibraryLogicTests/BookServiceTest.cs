using Data;
using Library.Data;
using Library.Data.Interfaces;
using Library.Data.Objects;
using Library.Logic.Services;
using LibraryLogicTests.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace LibraryLogicTests
{
    [TestClass]
    [DoNotParallelize]
    public class BookServiceTest
    {
        private MockRepo repo;
        private BookService bs;
        [TestInitialize]
        public void Setup()
        {
            repo = new MockRepo();
            bs = new BookService(repo);
        }

        [TestMethod]
        public void BorrowBookWorksCorrectly()
        {
            IBook book1 = DataFactory.CreateBook("1984", "George Orwell", "Dystopian", new DateTime(1949, 1, 1), "978-0451524935", 328);
            IUser user1 = DataFactory.CreateUser("John", "Pork", "jpork@email.com");
            repo.AddBook(book1);
            repo.AddUser(user1);
            var users = repo.GetAllUsers();
            var cat = repo.GetCatalog();
            var user = users.ElementAt(0);
            var book = cat.ElementAt(0);
            bs.BorrowBook(book, user);
            Assert.AreEqual(book.OwnerId, user.Guid);
        }

        [TestMethod]
        public void ReturnBookWorksCorrectly()
        {
            IBook book1 = DataFactory.CreateBook("1984", "George Orwell", "Dystopian", new DateTime(1949, 1, 1), "978-0451524935", 328);
            IUser user1 = DataFactory.CreateUser("John", "Pork", "jpork@email.com");
            repo.AddBook(book1);
            repo.AddUser(user1);
            var users = repo.GetAllUsers();
            var cat = repo.GetCatalog();
            var user = users.ElementAt(0);
            var book = cat.ElementAt(0);
            bs.BorrowBook(book, user);
            bs.ReturnBook(book, user);
            Assert.AreEqual(book.OwnerId, Guid.Empty);
        }
    }
}
