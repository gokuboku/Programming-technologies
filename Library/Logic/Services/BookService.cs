using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library.Data;
using Library.Data.Objects;

namespace Library.Logic.Services
{
    public class BookService
    {
        private Repository repo;

        public BookService(Repository repository)
        {
            this.repo = repository;
        }

        public void AddBook(Book book) => repo.AddBook(book);
        public void RemoveBook(Guid guid) => repo.RemoveBook(guid);
        public void BorrowBook(Guid bookGuid, Guid userGuid) => repo.BorrowBook(bookGuid, userGuid);
        public void ReturnBook(Guid bookGuid, Guid userGuid) => repo.ReturnBook(bookGuid, userGuid);
    }
}
