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
            repo = Repository.Create("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rorad\\Documents\\GitHub\\Programming-technologies\\Data\\Database\\LibraryDatabase.mdf;Integrated Security=True");
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
