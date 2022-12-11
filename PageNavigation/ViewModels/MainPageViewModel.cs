using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PageNavigation.ViewModels
{
	public class MainPageViewModel
	{
		public ICommand ShowDetailCommand { get; set; }

		public MainPageViewModel()
		{
			ShowDetailCommand = new Command(async () => await ShowDetail());
		}

		public async Task ShowDetail()
		{
			await Shell.Current.GoToAsync(nameof(DetailPage));
		}
	}
}
