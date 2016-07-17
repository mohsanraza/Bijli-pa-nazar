using System;
using System.Windows.Input;
using Microsoft.Phone.Controls;

namespace BijliPeNazar.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(PhoneApplicationPage mainPage)
            :base(mainPage)
        {
        }

        private ICommand _startCommand;
        public ICommand StartCommand
        {
            get { return _startCommand ?? (_startCommand = new RelayCommand(Start)); }
        }

        internal void Start(object obj)
        {
            MainPage.NavigationService.Navigate(new Uri("/AreaSelectView.xaml", UriKind.Relative));
        }
    }
}
