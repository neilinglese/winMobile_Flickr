using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace flickrJson
{
    public class flickrData
    {

        public Photoset photoset { get; set; }
        public string stat { get; set; }
    }
    public class Photo
    {
        public string id { get; set; }
        public string secret { get; set; }
        public string server { get; set; }
        public int farm { get; set; }
        public string title { get; set; }
        public string isprimary { get; set; }
        public string image { get; set; }
        public BitmapImage bp { get; set; }
        public string owner { get; set; }
    }

    public class Photoset
    {
        public string id { get; set; }
        public string primary { get; set; }
        public string owner { get; set; }
        public string ownername { get; set; }
        public List<Photo> photo { get; set; }
        public int page { get; set; }
        public int per_page { get; set; }
        public int perpage { get; set; }
        public int pages { get; set; }
        public string total { get; set; }
        public string title { get; set; }
    }

    public class RootObject
    {
        public Photoset photoset { get; set; }
        public string stat { get; set; }
    }
}