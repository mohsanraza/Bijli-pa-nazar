using BijliPeNazar.ViewModels;

namespace BijliPeNazar
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainPageViewModel(this);
        }
    }
}