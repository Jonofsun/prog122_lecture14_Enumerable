using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace prog122_lecture14_Enumerable
{
    public class InstagramPost
    {
        public enum PhotoFilter { Regular, GreyScale }

        PhotoFilter _filter;
        string _header;
        string _body;
        BitmapSource _photo;

      

        public InstagramPost(PhotoFilter filter, string header, string body, string filePath) // Pass in a filter, pass in a file path
        {
            _filter = filter;
            _header = header;
            _body = body;
            _filter = filter;
            if (filter == PhotoFilter.GreyScale)
            {
                _photo = GenerateGreyScale(GenerateImage(filePath));
            }
            else
            {
                _photo = GenerateImage(filePath);
            }
        }
        public string Header { get => _header; set => _header = value; }
        public string Body { get => _body; set => _body = value; }
        public BitmapSource Photo { get => _photo; set => _photo = value; }
        private BitmapImage GenerateImage(string filePath)
        {
            Uri uri = new Uri(filePath);
            BitmapImage bitmap = new BitmapImage(uri);
            return bitmap;
            //return new BitmapImage(new Uri(filePath));
        }
        private FormatConvertedBitmap GenerateGreyScale(BitmapImage bitmap)
        {
            //Uri uri = new Uri(filePath);
            //BitmapImage bitmap = new BitmapImage(uri);
            FormatConvertedBitmap grey = new FormatConvertedBitmap();
            grey.BeginInit();
            grey.Source = bitmap;
            grey.DestinationFormat = PixelFormats.Gray32Float;
            grey.EndInit();
            return grey;
        }
        public override string ToString()
        {
            return $"{Header}:\n{Body}";

        }
    }
}
