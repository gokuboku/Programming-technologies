using Library.Presentation.ViewModel;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace Library.Presentation.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            string _DBRelativePath = @"..\..\..\..\LibraryTest\Database\LibraryDatabase.mdf";
            string _BasePath = AppContext.BaseDirectory;
            string _DBPath = Path.GetFullPath(Path.Combine(_BasePath, _DBRelativePath));
            string connectionString = @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_DBPath};Integrated Security=True";
            var repo = VMDataFactory.CreateRepository(connectionString);
            repo.AddBook(VMDataFactory.CreateBook("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", DateTime.Now, "9780743273565", 180));
            var mainWindowViewModel = new MainWindowViewModel(repo);
            var mainWindow = new MainWindow(mainWindowViewModel);
            mainWindow.Show();
        }
    }
}
