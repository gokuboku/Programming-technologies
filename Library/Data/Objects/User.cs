using Library.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Objects
{
    internal class User: IUser
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public Guid GUID { get; private set; }
        public double FineAmount { get; private set; } = 0.0;
        public User(string name, string surname, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.GUID = Guid.NewGuid();
            this.Email = email;
        }

        public void SetFineAmount(double amount)
        {
            this.FineAmount = amount;
        }
    }
}
