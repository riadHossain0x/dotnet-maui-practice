using MauiAppDemo.ViewModels;

namespace MauiAppDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void OnUpdateRateClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                UpdateRateBtn.Text = $"Clicked {count} time";
            else
                UpdateRateBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(UpdateRateBtn.Text);
        }
    }
}