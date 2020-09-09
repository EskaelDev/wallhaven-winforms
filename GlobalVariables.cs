using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using wallpaper_forms.Models;
using System.Windows.Forms;

namespace wallpaper_forms
{
    public static class GlobalVariables
    {
        //public static string PhotoURL = "";
        //public static string ThumbnailURL = "";
        //public static string CurrentImageId = "";
        //public static string CurrentImageDetails = "";
        
        public static Image FullImage;


        public static string SearchBoxPlaceholderText => "Search...";
        public static bool Logged = false;
        public static string screenWidth => Screen.PrimaryScreen.Bounds.Width.ToString();
        public static string screenHeight => Screen.PrimaryScreen.Bounds.Height.ToString();
        public static ImageDetails CurrentImage{ get; set; }
       
        public static List<ImageDetails> Visited;
    }
}
