using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace wallpaper_forms.Models
{
    public class ImageDetails
    {
        public string Id { get; set; }
        public int MyProperty { get; set; }
        public string PhotoURL = "";
        public string ThumbnailURL = "";
        public string Description = "";
        public Image Thumbnail;
    }
}
