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
    public class LendingServiceTest
    {
        private MockRepo repo;
        private LendingService ls;
        [TestInitialize]
        public void Setup()
        {
            repo = new MockRepo();
            ls = new LendingService(repo);
        }

        [TestMethod]
        public void SetFineWorksCorrectly()
        {
            IUser user1 = DataFactory.CreateUser("John", "Pork", "jpork@email.com");
            repo.AddUser(user1);
            var users = repo.GetAllUsers();
            var usr = users.Last();
            ls.SetFine(usr, 100.0);
            Assert.AreEqual(100, usr.FineAmount);
        }
    }
}
