using System;
using Xamarin.Forms;

namespace Wibci.Xamarin.Forms.Converters
{
	public class NullValueToBooleanConverter : IValueConverter
	{
		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			bool retValue = value == null;
			if (parameter != null)
				retValue = !retValue;
			return retValue;
		}
		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}


	}
}

