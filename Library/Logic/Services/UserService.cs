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
    internal class UserService
    {
        private IRepository repo;

        public UserService(IRepository repository)
        {
            this.repo = repository;
        }

        public void AddUser(string name, string surname, string email) => repo.AddUser(name, surname, email);
        public void RemoveUser(Guid guid) => repo.RemoveUser(guid);
    }
}
