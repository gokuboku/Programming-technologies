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
    public class UserServiceTest
    {
        Repository repo = PredefinedDataGenerator.GeneratePredefinedRepo();
        User user1 = new User("Jonas", "Kiauliena", "jkiaul@email.com");

        [TestMethod]
        public void AddUserWorksCorrectly()
        {
            Repository repo = Repository.Create();
            UserService ls = new UserService(repo);
            ls.AddUser(user1);
            var usr = repo.GetAllUsers();
            var evs = repo.GetEvents();
            bool flag = (usr.Last().Name == user1.Name) && (evs.Last().Action == "AddUser");
            Assert.IsTrue(flag);
        }
    }
}
