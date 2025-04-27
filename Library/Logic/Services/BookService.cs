using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library.Data;
using Library.Data.Interfaces;

namespace Library.Logic.Services
{
    public class BookService
    {
        private Repository repo;

        public BookService(IRepository repo)
        {
            repo = new Repository();
        }

        public void AddBook(IBook book) => repo.AddBook(book);
        public void RemoveBook(IBook book) => repo.RemoveBook(book);
        public void BorrowBook(Guid bookGuid, Guid userGuid) => repo.BorrowBook(bookGuid, userGuid);
        public void ReturnBook(Guid bookGuid, Guid userGuid) => repo.ReturnBook(bookGuid, userGuid);
    }
}
