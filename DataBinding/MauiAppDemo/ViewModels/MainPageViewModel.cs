using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAppDemo.ViewModels
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private decimal _usdRate;
        public decimal UsdRate { get { return _usdRate; } set { _usdRate = value; OnPropertyChanaged(nameof(UsdRate)); } }

        private decimal _eurRate;
        public decimal EurRate { get { return _eurRate; } set { _eurRate = value; OnPropertyChanaged(nameof(EurRate)); } }

        private decimal _audRate;
        public decimal AudRate { get { return _audRate; } set { _audRate = value; OnPropertyChanaged(nameof(AudRate)); } }

        public ICommand UpdateRateCommand { get; set; }

        public MainPageViewModel()
        {
            UpdateRateCommand = new Command(() => OnUpdateRateClicked());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanaged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnUpdateRateClicked()
        {
            UsdRate = 12;
            EurRate = 16;
            AudRate = 20;
        }
    }
}
