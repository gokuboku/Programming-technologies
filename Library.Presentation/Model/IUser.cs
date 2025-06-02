using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Presentation.Model
{
    public interface IUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public Guid Guid { get; set; }

        public double FineAmount { get; set; }

        public void SetFineAmount(double amount);
    }
}
