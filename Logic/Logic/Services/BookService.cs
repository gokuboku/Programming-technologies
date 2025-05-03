using Library.Data;
using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class BookService
    {
        private Repository repo;

        public BookService(Repository repository)
        {
            this.repo = repository;
        }

        public void AddBook(IBook book) => repo.AddBook(book);
        public void RemoveBook(IBook book) => repo.RemoveBook(book);
        public void BorrowBook(IBook book, IUser user) => repo.BorrowBook(book, user);
        public void ReturnBook(IBook book, IUser user) => repo.ReturnBook(book, user);
    }
}
