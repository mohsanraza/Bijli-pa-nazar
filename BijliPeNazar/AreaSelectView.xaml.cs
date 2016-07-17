using BijliPeNazar.ViewModels;

namespace BijliPeNazar
{
    public partial class AreaSelectView
    {
        public AreaSelectView()
        {
            InitializeComponent();
            DataContext = new AreaSelectViewModel(this);
        }
    }
}