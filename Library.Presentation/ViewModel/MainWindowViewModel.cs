using Library.Data.Interfaces;
using Library.Presentation.Model;
using Library.Presentation.MVVM;
using System.Collections.ObjectModel;

namespace Library.Presentation.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<IUser> Users { get; set; } = new();
        public MainWindowViewModel()
        {
            Users.Add(new User { Name = "John", Surname = "Pork", Email = "jpork" });
            Users.Add(new User { Name = "Tralalero", Surname = "Tralala", Email = "ttrala" });
        }

        private IUser selectedUser;

        public IUser SelectedUser
        {
            get { return selectedUser; }
            set 
            { 
                selectedUser = value; 
                OnPropertyChanged();
            }
        }

    }
}
