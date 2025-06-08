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

namespace LibraryLogicTests
{
    [TestClass]
    [DoNotParallelize]
    public class UserServiceTest
    {
        private IRepository repo;
        private UserService ls;
        [TestInitialize]
        public void Setup()
        {
            repo = new MockRepo();
            ls = new UserService(repo);
        }

        [TestMethod]
        public void AddUserWorksCorrectly()
        {
            IUser user1 = DataFactory.CreateUser("John", "Pork", "jpork@email.com");
            IUser user2 = DataFactory.CreateUser("Tim", "Cheese", "tcheese@email.com");
            ls.AddUser(user1);
            Assert.IsTrue(repo.GetAllUsers().Count() == 1);
            Assert.AreEqual(true, repo.ContainsUser(user1));
            ls.AddUser(user2);
            Assert.IsTrue(repo.GetAllUsers().Count() == 2);
            Assert.AreEqual(true, repo.ContainsUser(user2));
        }
    }
}
