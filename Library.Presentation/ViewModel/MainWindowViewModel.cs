using Library.Data;
using Library.Presentation.Model;
using Library.Presentation.MVVM;
using System.Collections.ObjectModel;

namespace Library.Presentation.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private Repository _repo;
        public ObservableCollection<User> Users { get; set; } = new();
        public ObservableCollection<Book> Books { get; set; } = new();
        public RelayCommand ShowAllBooksCommand => new RelayCommand(execute => LoadAllBooks());
        public MainWindowViewModel(Repository repo)
        {
            _repo = repo;
            foreach (var user in repo.GetAllUsers())
            {
                Users.Add(new User
                {
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    Guid = user.Guid,
                    FineAmount = user.FineAmount
                });
            }

            foreach (var book in repo.GetCatalog())
            {
                Books.Add(new Book(
                    book.Isbn,
                    book.Title,
                    book.Author,
                    book.Genre,
                    book.Year,
                    book.Guid,
                    book.Pages)
                {
                    OwnerId = book.OwnerId,
                    IsAvailable = book.IsAvailable
                });
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
                Books.Add(new Book(
                    book.Isbn,
                    book.Title,
                    book.Author,
                    book.Genre,
                    book.Year,
                    book.Guid,
                    book.Pages)
                {
                    OwnerId = book.OwnerId,
                    IsAvailable = book.IsAvailable
                });
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
