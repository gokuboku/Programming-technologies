using Library.Data;
using Library.Data.Interfaces;

namespace Library.Logic.Services
{
    public class LendingService
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
