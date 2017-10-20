using Ninject;
using Prism.Ninject;
using PrismNinjectApp1.Views;
using System.Windows;

namespace PrismNinjectApp1
{
    class Bootstrapper : NinjectBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Kernel.TryGet<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
