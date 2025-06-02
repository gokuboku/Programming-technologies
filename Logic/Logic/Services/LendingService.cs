using Library.Data;
using Library.Data.Interfaces;
using Logic.Logic.Interfaces;

namespace Library.Logic.Services
{
    public class LendingService : ILendingService
    {
        private Repository repo;

        public LendingService(string connectionString)
        {
            repo = Repository.Create(connectionString);
        }

        public LendingService(Repository repo)
        {
            this.repo = repo;
        }

        public void SetFine(IUser user, double amount) => repo.SetFine(user, amount);
    }
}
