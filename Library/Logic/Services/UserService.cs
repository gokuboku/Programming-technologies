using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Library.Data;

namespace Library.Logic.Services
{
    internal class UserService
    {
        private Repository repo;

        public UserService(Repository repository)
        {
            this.repo = repository;
        }

        public void AddUser(string name, string surname, string email) => repo.AddUser(name, surname, email);
        public void RemoveUser(Guid guid) => repo.RemoveUser(guid);
    }
}
