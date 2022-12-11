using PageNavigation.ViewModels;

namespace PageNavigation
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