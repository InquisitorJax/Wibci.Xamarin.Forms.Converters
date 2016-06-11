using System;
using System.Globalization;
using Xamarin.Forms;


namespace Wibci.Xamarin.Forms.Converters
{
	public class HexStringToColorConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
				return Color.Accent;
			string hexColor = (string)value;
			return Color.FromHex(hexColor);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}

