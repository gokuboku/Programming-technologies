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
        User user1 = new User("John", "Pork", "jpork@email.com");
        Book book1 = new Book("1984", "George Orwell", "Dystopian", 1949, "978-0451524935", 328);

        [TestMethod]
        public void GiveFineWorksCorrectly()
        {
            Repository repo = new Repository();
            LendingService ls = new LendingService(repo);
            repo.AddUser(user1);
            ls.GiveFine(user1.GUID, 100.0);
            var usr = repo.GetAllUsers();
            var evs = repo.GetEvents();
            bool flag = (usr[0].FineAmount == 100.0) && (evs.Last().Action == "Fine_Given");
            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void PayFineWorksCorrectly()
        {
            Repository repo = new Repository();
            LendingService ls = new LendingService(repo);
            repo.AddUser(user1);
            ls.GiveFine(user1.GUID, 100.0);
            ls.PayFine(user1.GUID, 100.0);
            var usr = repo.GetAllUsers();
            var evs = repo.GetEvents();
            bool flag = (usr[0].FineAmount == 0.0) && (evs.Last().Action == "Fine_Paid");
            Assert.IsTrue(flag);
        }
    }
}
