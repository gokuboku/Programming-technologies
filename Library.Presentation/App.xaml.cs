using System.Configuration;
using System.Data;
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
            
            var mainWindowViewModel = new ViewModel.MainWindowViewModel();
            var mainWindow = new MainWindow(mainWindowViewModel);
            mainWindow.Show();
        }
    }
}
