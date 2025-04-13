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
        User user1 = new User("John", "Pork", "jpork@email.com");
        Book book1 = new Book("1984", "George Orwell", "Dystopian", 1949, "978-0451524935", 328);
        [TestMethod]
        public void AddUserWorksCorrectly()
        {
            Repository repo = new Repository();
            UserService ls = new UserService(repo);
            ls.AddUser(user1);
            var usr = repo.GetAllUsers();
            var evs = repo.GetEvents();
            bool flag = (usr[0].Name == user1.Name) && (evs.Last().Action == "User_added");
            Assert.IsTrue(flag);
        }
    }
}
