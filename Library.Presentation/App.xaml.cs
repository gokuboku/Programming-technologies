using Library.Data;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace Library.Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            string _DBRelativePath = @"..\..\..\Database\LibraryDatabase.mdf";
            string _BasePath = AppContext.BaseDirectory;
            string _DBPath = Path.GetFullPath(Path.Combine(_BasePath, _DBRelativePath));
            string connectionString = @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={_DBPath};Integrated Security=True";
            using (var repo = Repository.Create(connectionString) )
            {            
                var mainWindowViewModel = new ViewModel.MainWindowViewModel(repo);
                var mainWindow = new MainWindow(mainWindowViewModel);
                mainWindow.Show();

            }

        }
    }
}
