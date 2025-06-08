using Library.Data.Interfaces;
using Library.Presentation.Model;
using System.Collections.ObjectModel;

namespace Library.Presentation.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private IRepository _repo;
        public ObservableCollection<IUser> Users { get; set; } = new();
        public ObservableCollection<IBook> Books { get; set; } = new();
        public RelayCommand ShowAllBooksCommand => new RelayCommand(execute => LoadAllBooks());
        public MainWindowViewModel(IRepository repo)
        {
            _repo = repo;
            foreach (var user in repo.GetAllUsers())
            {
                Users.Add(ModelDataFactory.CreateUser(user.Name, user.Surname, user.Email));
            }

            foreach (var book in repo.GetCatalog())
            {
                var temp = ModelDataFactory.CreateBook(book.Title, book.Author, book.Genre, book.Year, book.Isbn, book.Pages);
                temp.SetOwner(book.OwnerId);
                temp.SetAvailability(book.IsAvailable);
                Books.Add(temp);
            }
        }

        private bool isUserSelected;

        public bool IsUserSelected
        {
            get { return isUserSelected; }
            set
            {
                isUserSelected = value;
                OnPropertyChanged();
            }
        }

        private void LoadAllBooks()
        {
            Books.Clear();
            foreach (var book in _repo.GetCatalog())
            {
                var temp = ModelDataFactory.CreateBook(book.Title, book.Author, book.Genre, book.Year, book.Isbn, book.Pages);
                temp.SetOwner(book.OwnerId);
                temp.SetAvailability(book.IsAvailable);
                Books.Add(temp);
            }
        }

        private IBook selectedBook;

        public IBook SelectedBook
        {
            get { return selectedBook; }
            set
            {
                selectedBook = value;
                OnPropertyChanged();
            }
        }

        private IUser selectedUser;

        public IUser SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                IsUserSelected = selectedUser != null;
                OnPropertyChanged();
            }
        }

    }
}
