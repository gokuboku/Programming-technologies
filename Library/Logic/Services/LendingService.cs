using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library.Data;

namespace Library.Logic.Services
{
    internal class LendingService
    {
        private Repository repo;

        public LendingService(Repository repository)
        {
            this.repo = repository;
        }

        public void BorrowBook(Guid bookGuid, Guid userGuid) => repo.BorrowBook(bookGuid, userGuid);
        public void ReturnBook(Guid bookGuid, Guid userGuid) => repo.ReturnBook(bookGuid, userGuid);

        public void GiveFine(Guid userGuid, double amount) => repo.GiveFine(userGuid, amount);
        public void PayFine(Guid userGuid, double amount) => repo.PayFine(userGuid, amount);
    }
}
