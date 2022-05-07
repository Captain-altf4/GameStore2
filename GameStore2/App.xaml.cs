using System.Windows;

namespace GameStore2
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            WindowsBuilder.ShowMainWindow();
            base.OnStartup(e);
        }
    }
}
