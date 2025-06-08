using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Data;
using Library.Data;
using Library.Data.Interfaces;
using Logic.Logic.Interfaces;

namespace Library.Logic.Services
{
    internal class UserService : IUserService
    {
        private IRepository repo;

        public UserService(string connectionString)
        {
            this.repo = DataFactory.CreateRepository(connectionString);
        }

        public UserService(IRepository Repo)
        {
            repo = Repo;
        }

        public void AddUser(IUser user) => repo.AddUser(user);
        public void RemoveUser(IUser user) => repo.RemoveUser(user);
        public IEnumerable<IUser> GetNumberOfUsers(int number, int offset) => repo.GetNumberOfUsers(number, offset);
    }
}
