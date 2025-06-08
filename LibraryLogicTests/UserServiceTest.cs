using LibraryLogicTests.MockData;
using Logic.Logic;
using Logic.Logic.Interfaces;

namespace LibraryLogicTests
{
    [TestClass]
    [DoNotParallelize]
    public class UserServiceTest
    {
        private MockRepo repo;
        [TestInitialize]
        public void Setup()
        {
            repo = new MockRepo();
        }

        [TestMethod]
        public void AddUserWorksCorrectly()
        {
            IUserLogic user1 = LogicDataFactory.CreateUser("John", "Pork", "jpork@email.com");
            IUserLogic user2 = LogicDataFactory.CreateUser("Tim", "Cheese", "tcheese@email.com");
            repo.AddUser(user1);
            Assert.IsTrue(repo.GetAllUsers().Count() == 1);
            Assert.AreEqual(true, repo.ContainsUser(user1));
            repo.AddUser(user2);
            Assert.IsTrue(repo.GetAllUsers().Count() == 2);
            Assert.AreEqual(true, repo.ContainsUser(user2));
        }
    }
}
