using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImgDB
{
    public class Userimg
    {
        public Userimg(string title, string serializedImage)
        {
            Title = title;
            SerializedImage = serializedImage;
        }

        public Userimg(int iD, string title, string serializedImage)
        {
            ID = iD;
            Title = title;
            SerializedImage = serializedImage;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string SerializedImage { get; set; }

        public string ImageToString(Image img)
        {
            ImageFormat format = img.RawFormat;
            MemoryStream ms = new MemoryStream();
            img.Save(ms, format);
            byte[] array = ms.ToArray();
            return Convert.ToBase64String(array);
        }

        public Image StringToImage(string imageString)
        {
            byte[] array = Convert.FromBase64String(imageString);
            Image image = Image.FromStream(new MemoryStream(array));
            return image;
        }
    }
}
