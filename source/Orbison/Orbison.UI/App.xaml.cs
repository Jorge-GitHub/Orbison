using System.Diagnostics;
using System.Windows;

namespace Orbison.UI;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    /// <summary>
    /// Save an unhanded exception.
    /// </summary>
    private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
    {
        //e.Exception.Save();
        e.Handled = true;
    }

    /// <summary>
    /// Method to run when the application closes.
    /// </summary>
    private void Application_Exit(object sender, ExitEventArgs e)
    {
        (Process.GetCurrentProcess()).Kill();
    }
}
