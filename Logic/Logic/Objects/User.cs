using Library.Data.Interfaces;

namespace Library.Logic.Objects
{
    internal class User : IUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public Guid Guid { get; set; }

        public double FineAmount { get; set; }

        public void SetFineAmount(double amount)
        {
            FineAmount = amount;
        }
    }
}
