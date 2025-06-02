//using Library.Data;
//using Library.Data.Objects;
//using Library.Logic.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LibraryTest
//{
//    [TestClass]
//    public class UserServiceTest
//    {
//        private Repository repo;
//        [TestInitialize]
//        public void Setup()
//        {
//            repo = Repository.Create("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rorad\\Documents\\GitHub\\Programming-technologies\\Data\\Database\\LibraryDatabase.mdf;Integrated Security=True");
//            repo.TruncateAllData();
//        }
//        User user1 = new User("Jonas", "Kiauliena", "jkiaul@email.com");

//        [TestMethod]
//        public void AddUserWorksCorrectly()
//        {
//            UserService ls = new UserService(repo);
//            ls.AddUser(user1);
//            var usr = repo.GetAllUsers();
//            var evs = repo.GetEvents();
//            bool flag = (usr.Last().Name == user1.Name) && (evs.Last().Action == "AddUser");
//            Assert.IsTrue(flag);
//        }
//    }
//}
