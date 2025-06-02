using Library.Data.Interfaces;

namespace Logic.Logic.Interfaces
{
    public interface ILendingService
    {
        public void SetFine(IUser user, double amount);
    }
}
