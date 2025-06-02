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
    [DoNotParallelize]
    public class UserServiceTest
    {
        private Repository repo;
        private UserService ls;
        [TestInitialize]
        public void Setup()
        {
            string _DBRelativePath = @"..\..\..\Database\LibraryDatabase.mdf";
            string _BasePath = AppContext.BaseDirectory;
            string _DBPath = Path.GetFullPath(Path.Combine(_BasePath, _DBRelativePath));
            string connectionString = @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_DBPath};Integrated Security=True";
            repo = Repository.Create(connectionString);
            repo.TruncateAllData();
            ls = new UserService(repo);
        }

        [TestMethod]
        public void AddUserWorksCorrectly()
        {
            User user1 = PredefinedDataGenerator.GenerateUser1();
            User user2 = PredefinedDataGenerator.GenerateUser2();
            ls.AddUser(user1);
            Assert.IsTrue(repo.GetAllUsers().Count() == 1);
            Assert.AreEqual(true, repo.ContainsUser(user1));
            ls.AddUser(user2);
            Assert.IsTrue(repo.GetAllUsers().Count() == 2);
            Assert.AreEqual(true, repo.ContainsUser(user2));
        }
    }
}
