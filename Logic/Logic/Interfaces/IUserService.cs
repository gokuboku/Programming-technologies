using Library.Data.Interfaces;

namespace Logic.Logic.Interfaces
{
    public interface IUserService
    {
        public void AddUser(IUser user);
        public void RemoveUser(IUser user);
        public IEnumerable<IUser> GetNumberOfUsers(int number, int offset);
    }
}
