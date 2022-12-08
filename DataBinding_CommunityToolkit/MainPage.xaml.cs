using DataBinding_CommunityToolkit.ViewModels;

namespace DataBinding_CommunityToolkit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }
}