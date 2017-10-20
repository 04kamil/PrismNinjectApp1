using Prism.Mvvm;

namespace PrismNinjectApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Ninject Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
