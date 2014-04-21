using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace HubCrawl.Models
{
    public class MetroMenuItem
    {
        private Geometry _image;
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public Geometry Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public MetroMenuItem(string title, Geometry image)
        {
            this._image = image;
            this._title = title;
        }
    }
}
