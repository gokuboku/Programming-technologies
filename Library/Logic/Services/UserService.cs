using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library.Data;
using Library.Data.Interfaces;
using Library.Data.Objects;

namespace Library.Logic.Services
{
    public class UserService
    {
        private Repository repo;

        public UserService(Repository repository)
        {
            this.repo = repository;
        }

        public void AddUser(IUser user) => repo.AddUser(user);
        public void RemoveUser(IUser user) => repo.RemoveUser(user);
    }
}
