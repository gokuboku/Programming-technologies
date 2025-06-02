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
    public class UserService
    {
        private Repository repo;

        public UserService(string connectionString)
        {
            this.repo = Repository.Create(connectionString);
        }

        public UserService(Repository Repo)
        {
            repo = Repo;
        }

        public void AddUser(IUser user) => repo.AddUser(user);
        public void RemoveUser(IUser user) => repo.RemoveUser(user);
        public IEnumerable<IUser> GetNumberOfUsers(int number, int offset) => repo.GetNumberOfUsers(number, offset);
    }
}
