using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace DataBinding_CommunityToolkit.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
		private decimal _usdRate;

		public decimal UsdRate
		{
			get { return _usdRate; }
			set { SetProperty(ref _usdRate, value); }
		}

		private decimal _euroRate;

		public decimal EuroRate
		{
			get { return _euroRate; }
			set { SetProperty(ref _euroRate, value); }
		}

		private decimal _audRate;

		public decimal AudRate
		{
			get { return _audRate; }
			set { SetProperty(ref _audRate, value); }
		}

		public ICommand UpdateRateCommand { get; set; }

		public MainPageViewModel()
		{
			UpdateRateCommand = new Command(UpdateRate);
		}

		private void UpdateRate()
		{
			UsdRate = 10;
			EuroRate = 10;
			AudRate = 100;
		}
	}
}
