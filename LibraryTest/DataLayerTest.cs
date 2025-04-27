using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data;
using Library.Data.Objects;

namespace LibraryTest
{
    [TestClass]
    public class DataLayerTest
    {
        User user1 = new User("John", "Pork", "jpork@email.com");
        User user2 = new User("Tim", "Cheese", "tcheese@email.com");
        User user3 = new User("Tralalero", "Tralala", "ttralala@email.com");

        Book book1 = new Book("1984", "George Orwell", "Dystopian", 1949, "978-0451524935", 328);
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "Classic", 1960, "978-0061120084", 336);
        Book book3 = new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy", 1937, "978-0547928227", 310);


        [TestMethod]
        public void GetAllUsersReturnsCorrectValue()
        {
            Repository repo = new Repository();
            repo.AddUser(user1);
            repo.AddUser(user2);
            Assert.AreEqual(user2.Name, repo.GetAllUsers()[1].Name);
        }

        [TestMethod]
        public void GetCatalogReturnsCorrectValue()
        {
            Repository repo = new Repository();
            repo.AddBook(book1);
            repo.AddBook(book2);
            Assert.AreEqual(book1.Title, repo.GetCatalog()[0].Title);
        }

        [TestMethod]
        public void GetLibraryStateReturnsCorrectValue()
        {
            Repository repo = new Repository();
            repo.AddUser(user1);
            repo.AddBook(book1);
            var state = repo.GetLibraryState();
            bool flag = (state.Users[0].Name == user1.Name) &&
                (state.Books[0].Title == book1.Title);
            Assert.IsTrue(flag);
        }

        [TestMethod]
        public void GetEventsRetursCorrectValue()
        {
            Repository repo = new Repository();
            repo.AddUser(user1);
            Assert.AreEqual(repo.GetEvents()[0].Action, "User_added");
        }

        [TestMethod]
        public void RemoveBookIsSuccessful() 
        {
            Repository repo = new Repository();
            repo.AddBook(book1);
            repo.AddBook(book2);
            repo.RemoveBook(book1.Guid);
            Assert.IsNull(repo.GetCatalog().Find(b => b.Guid == book1.Guid));
        }
    }
}
