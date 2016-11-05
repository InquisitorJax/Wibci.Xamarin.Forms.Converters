# Wibci.Xamarin.Forms.Converters
Common Value Converters for use with Xamarin Forms apps

TODO: Update sample app with TrimString / ImageSource / Hex converter examples

###BooleanToInvertedBoolean
inverts a boolean value
Sample Xaml:

###ByteArrayToImageSource
converts a byte[] image property to an image source for binding to Image.Source
Can also specify a filler image if the byte[] is null

###HexStringToColor
converts a hex string to Xamarin Forms Color 

###NullValueToBoolean
converts null to true ; false if parameter passed

###EmptyStringToFillText
Display a string like "<Not Available>" if the bound value is empty.
Specify default value in parameter

###TrimString
Converts long string to trimmed string appended by '...'
Default trim length is 100, if not specified in parameter
