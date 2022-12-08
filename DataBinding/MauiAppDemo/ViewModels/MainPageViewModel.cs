using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppDemo.ViewModels
{
    internal class MainPageViewModel
    {
        public decimal UsdRate { get; set; }
        public decimal EurRate { get; set; }
        public decimal AudRate { get; set; }

        public ICommand UpdateRateCommand { get; set; }

        public MainPageViewModel()
        {
            UpdateRateCommand = new Command(() => OnUpdateRateClicked());
        }

        private void OnUpdateRateClicked()
        {
            UsdRate = 12;
            EurRate = 16;
            AudRate = 20;
        }
    }
}
