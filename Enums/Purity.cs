using System;
using System.Collections.Generic;
using System.Text;

namespace wallpaper_forms.Enums
{
    public static class Purity
    {
        public static int Sfw = 100;
        public static int Sketchy = 010;
        public static int Nsfw = 001;
        public static string SfwSketchy = "110";
        public static string SfwNsfw = "101";
        public static string SketchyNsfw = "011";
        public static string All = "111";
    }
}
