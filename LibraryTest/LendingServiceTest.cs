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
    public class LendingServiceTest
    {
        private Repository repo;
        private LendingService ls;
        [TestInitialize]
        public void Setup()
        {
            repo = Repository.Create("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rorad\\Documents\\GitHub\\Programming-technologies\\Data\\Database\\LibraryDatabase.mdf;Integrated Security=True");
            repo.TruncateAllData();
            ls = new LendingService(repo);
        }

        [TestMethod]
        public void SetFineWorksCorrectly()
        {
            User user1 = PredefinedDataGenerator.GenerateUser1();
            repo.AddUser(user1);
            var users = repo.GetAllUsers();
            var usr = users.Last();
            ls.SetFine(usr, 100.0);
            Assert.AreEqual(100, usr.FineAmount);
        }
    }
}
