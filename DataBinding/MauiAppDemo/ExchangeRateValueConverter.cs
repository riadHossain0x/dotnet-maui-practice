using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppDemo
{
    internal class ExchangeRateValueConverter : IValueConverter
    {
        public string CurrencySymbol { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var exchangeRate = decimal.Parse(value.ToString());
            return $"{exchangeRate.ToString("0.00")} {CurrencySymbol}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
