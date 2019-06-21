using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgDB
{
    class Image
    {
        public Image(string title, string serializedImage)
        {
            Title = title;
            SerializedImage = serializedImage;
        }

        public Image(int iD, string title, string serializedImage)
        {
            ID = iD;
            Title = title;
            SerializedImage = serializedImage;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string SerializedImage { get; set; }
    }
}
