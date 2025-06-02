using Library.Presentation.Model;
using Library.Presentation.MVVM;
using System.Collections.ObjectModel;

namespace Library.Presentation.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<User> Users { get; set; } = new();
        public ObservableCollection<Book> Books { get; set; } = new();
        public MainWindowViewModel()
        {
            
            Users.Add(new User { Name = "John", Surname = "Pork", Email = "jpork", Guid = Guid.NewGuid()});
            Users.Add(new User { Name = "Tralalero", Surname = "Tralala", Email = "ttrala", Guid = Guid.NewGuid()});

            Books.Add(new Book("978-3-16-148410-0", "The Silent Patient", "Alex Michaelides", "Thriller",
                new DateTime(2019, 2, 5), Guid.NewGuid(), 336));
            Books.Add(new Book("978-0-7432-7356-5", "Angels & Demons", "Dan Brown", "Mystery", new DateTime(2000, 5, 1), Guid.NewGuid(), 572));
            Books.Add(new Book("978-0-452-28423-4", "1984", "George Orwell", "Dystopian", new DateTime(1949, 6, 8), Guid.NewGuid(), 328));
            Books.Add(new Book("978-0-06-112008-4", "To Kill a Mockingbird", "Harper Lee", "Fiction", new DateTime(1960, 7, 11), Guid.NewGuid(), 281));
            Books.Add(new Book("978-1-250-30686-3", "The Midnight Library", "Matt Haig", "Fantasy", new DateTime(2020, 8, 13), Guid.NewGuid(), 304));
        }

        private bool isUserSelected;

        public bool IsUserSelected
        {
            get { return isUserSelected; }
            set 
            {
                isUserSelected = SelectedUser.Guid != Guid.Empty;
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

    }
}
