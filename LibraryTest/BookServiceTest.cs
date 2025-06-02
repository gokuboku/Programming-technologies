using Library.Data;
using Library.Data.Objects;
using Library.Logic.Services;
using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    [TestClass]
    [DoNotParallelize]
    public class BookServiceTest
    {
        private Repository repo;
        private BookService bs;
        [TestInitialize]
        public void Setup()
        {
            string _DBRelativePath = @"..\..\..\Database\LibraryDatabase.mdf";
            string _BasePath = AppContext.BaseDirectory;
            string _DBPath = Path.GetFullPath(Path.Combine(_BasePath, _DBRelativePath));
            string connectionString = @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_DBPath};Integrated Security=True";
            repo = Repository.Create(connectionString);
            repo.TruncateAllData();
            bs = new BookService(repo);
        }

        [TestMethod]
        public void BorrowBookWorksCorrectly()
        {
            Book book1 = PredefinedDataGenerator.GenerateBook1();
            User user1 = PredefinedDataGenerator.GenerateUser1();
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
            Book book1 = PredefinedDataGenerator.GenerateBook1();
            User user1 = PredefinedDataGenerator.GenerateUser1();
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
