using Prism.Mvvm;

namespace SampleApp
{
    public class SampleModel : BindableBase
    {
        private string _hexColor;
        private byte[] _image;
        private bool _isSomething;
        private string _text;

        public string HexColor
        {
            get { return _hexColor; }
            set { SetProperty(ref _hexColor, value); }
        }

        public byte[] Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }

        public bool IsSomething
        {
            get { return _isSomething; }
            set { SetProperty(ref _isSomething, value); }
        }

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}