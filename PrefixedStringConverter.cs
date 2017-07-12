using System;
using System.Globalization;
using Xamarin.Forms;

namespace Wibci.Xamarin.Forms.Converters
{
    public class PrefixedStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string prefix = parameter as string;
            string fullString = value as string;
            if (string.IsNullOrEmpty(prefix))
                return value;

            string displayValue = fullString;
            if (!string.IsNullOrEmpty(displayValue) && displayValue.StartsWith(prefix))
            {
                displayValue = displayValue.Substring(prefix.Length, displayValue.Length - prefix.Length);
            }
            return displayValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string partialString = value as string;
            string prefix = parameter as string;

            string fullString = prefix + partialString;

            return fullString;
        }
    }