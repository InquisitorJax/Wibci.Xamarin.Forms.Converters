using System;
using Xamarin.Forms;

namespace Wibci.Xamarin.Forms.Converters
{
	public class TrimStringConverter : IValueConverter
	{
		#region IValueConverter implementation
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			string stringValue = (string)value;
			if (!string.IsNullOrEmpty(stringValue))
			{
				stringValue = stringValue.Replace(Environment.NewLine, "");

				int trimLength = 100;
				if (parameter != null)
				{
					trimLength = int.Parse(parameter.ToString());
				}

				if (stringValue.Length > trimLength)
				{
					stringValue = stringValue.Substring(0, trimLength);
					stringValue += "...";
				}
			}
			return stringValue;
		}
		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value;
		}
		#endregion
	}
}

