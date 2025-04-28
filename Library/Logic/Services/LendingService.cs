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
    public class LendingService
    {
        private Repository repo;

        public LendingService(Repository repository)
        {
            repo = repository;
        }

        public void SetFine(IUser user, double amount) => repo.SetFine(user, amount);
    }
}
