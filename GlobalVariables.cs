using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using wallpaper_forms.Models;

namespace wallpaper_forms
{
    public static class GlobalVariables
    {
        public static string PhotoURL = "";
        public static string ThumbnailURL = "";
        public static string CurrentImageId = "";
        public static string CurrentImageDetails = "";
        public static Image FullImage;
        public static string SearchBoxPlaceholderText => "Search...";
        public static bool Logged = false;
    }
}
