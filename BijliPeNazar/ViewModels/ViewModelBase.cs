using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Phone.Controls;

namespace BijliPeNazar.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase(PhoneApplicationPage mainPage)
        {
            MainPage = mainPage;
        }

        protected PhoneApplicationPage MainPage { get; set; }

        // This event fires when the model's data changes. The View will consume the event
        public event PropertyChangedEventHandler PropertyChanged;

        internal void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
