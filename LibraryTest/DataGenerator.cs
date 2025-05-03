using Library.Data;
using Library.Data.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    internal class DataGenerator
    {
        public static Repository GenerateRepo()
        {
            Repository repo = Repository.Create();

            User user1 = new User("John", "Pork", "jpork@email.com");
            User user2 = new User("Tim", "Cheese", "tcheese@email.com");
            User user3 = new User("Tralalero", "Tralala", "ttralala@email.com");

            Book book1 = new Book("1984", "George Orwell", "Dystopian", 1949, "978-0451524935", 328);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "Classic", 1960, "978-0061120084", 336);
            Book book3 = new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy", 1937, "978-0547928227", 310);

            repo.AddUser(user1);
            repo.AddUser(user2);
            repo.AddUser(user3);


            repo.AddBook(book1);
            repo.AddBook(book2);
            repo.AddBook(book3);
            return repo;
        }
    }
}
