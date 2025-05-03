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
        Repository repo = DataGenerator.GenerateRepo();

        [TestMethod]
        public void SetFineWorksCorrectly()
        {
            LendingService ls = new LendingService(repo);
            var users = repo.GetAllUsers();
            var usr = users.Last();
            ls.SetFine(usr, 100.0);
            var evs = repo.GetEvents();
            bool flag = (usr.FineAmount == 100.0) && (evs.Last().Action == "SetFine");
            Assert.IsTrue(flag);
        }
    }
}
