using Data;
using Library.Data;
using Library.Data.Interfaces;
using Logic.Logic.Interfaces;

namespace Library.Logic.Services
{
    internal class LendingService : ILendingService
    {
        private IRepository repo;

        public LendingService(string connectionString)
        {
            this.repo = DataFactory.CreateRepository(connectionString);
        }

        public LendingService(IRepository repo)
        {
            this.repo = repo;
        }

        public void SetFine(IUser user, double amount) => repo.SetFine(user, amount);
    }
}
