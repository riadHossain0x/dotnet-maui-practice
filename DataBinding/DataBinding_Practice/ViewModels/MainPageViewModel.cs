using System.ComponentModel;
using System.Windows.Input;

namespace DataBinding_Practice.ViewModels
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private decimal _usdRate;
        private decimal _eurRate;
        private decimal _audRate;
        public decimal UsdRate { get { return _usdRate; } set { _usdRate = value; OnPropertyChanged(nameof(UsdRate)); } }
        public decimal EurRate { get { return _eurRate; } set { _eurRate = value; OnPropertyChanged(nameof(EurRate)); } }
        public decimal AudRate { get { return _audRate; } set { _audRate = value; OnPropertyChanged(nameof(AudRate)); } }

        public ICommand UpdateConvertionRateCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged.Invoke(this, 
            new PropertyChangedEventArgs(propertyName));

        public MainPageViewModel()
        {
            UpdateConvertionRateCommand = new Command(UpdateConvertionRate);
        }

        public void UpdateConvertionRate()
        {
            UsdRate = 10;
            EurRate = 15;
            AudRate = 20;
        }
    }
}
