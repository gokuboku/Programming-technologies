using Library.Data;
using Library.Data.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTest
{
    internal class PredefinedDataGenerator
    {
        public static Repository GeneratePredefinedRepo()
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

    internal class RandomDataGenerator
    {
        private static Random random = new Random();
        public static Repository GenerateRandomRepo(int userCount, int bookCount)
        {
            Repository repo = Repository.Create();
            for (int i = 0; i < userCount; i++)
            {
                string name = "User" + i;
                string surname = "Surname" + i;
                string email = "user" + i + "@example.com";
                User user = new User(name, surname, email);
                repo.AddUser(user);
            }
            for (int i = 0; i < bookCount; i++)
            {
                string title = "Book" + i;
                string author = "Author" + i;
                string genre = "Genre" + random.Next(1, 5);
                int year = random.Next(1900, 2023);
                string isbn = random.Next(100, 999).ToString() + "-" + random.Next(1000000000, int.MaxValue);
                int pages = random.Next(100, 1000);
                Book book = new Book(title, author, genre, year, isbn, pages);
                repo.AddBook(book);
            }
            return repo;
        }
    }
}
