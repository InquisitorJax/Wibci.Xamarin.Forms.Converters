# Wibci.Xamarin.Forms.Converters
Common Value Converters for use with Xamarin Forms apps

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

###TrimString
Converts long string to trimmed string appended by '...'
Default trim length is 100, if not specified in parameter
