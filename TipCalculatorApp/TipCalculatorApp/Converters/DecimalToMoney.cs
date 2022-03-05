using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TipCalculatorApp.Converters
{
    public class DecimalToMoney : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal valor = (decimal)value;
            return valor.ToString("C");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valor = (string)value;
            // remueve el primer caracter, en este caso el signo $
            return valor.Remove(0);
        }
    }
}
