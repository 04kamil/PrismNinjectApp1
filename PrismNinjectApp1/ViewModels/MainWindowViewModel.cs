using Prism.Mvvm;
using PrismNinjectApp1.Model;
using System.Collections.Generic;

namespace PrismNinjectApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Metoda analizy hierarchii Saaty’ego";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private List<Alternative> _alternatives;
        private List<Alternative> Alternatives
        {
            set { _alternatives = value; }
            get { return _alternatives; }
        }

        //private List<

        public MainWindowViewModel()
        {

        }
    }
}
