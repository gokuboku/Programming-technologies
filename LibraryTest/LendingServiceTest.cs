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
        public void SetFineWorksCorrectly()
        {
            Repository repo = new Repository();
            LendingService ls = new LendingService(repo);
            repo.AddUser(user1);
            var users = repo.GetAllUsers();
            var usr = users.Last();
            ls.SetFine(usr, 100.0);
            var evs = repo.GetEvents();
            bool flag = (usr.FineAmount == 100.0) && (evs.Last().Action == "SetFine");
            Assert.IsTrue(flag);
        }
    }
}
