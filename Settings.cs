using System;
using System.Collections.Generic;
using System.Text;
using wallpaper_forms.Services;

namespace wallpaper_forms
{
    public class Settings
    {
        private static int seedLength => 6;

        public static string LeastResolution = "2560x1440";
        public static string Ratio = "16x9";
        public static string Page => "1";
        public static string WallhavenUri => "https://wallhaven.cc/api/v1/search";
        public static string Seed => RandomSeedService.RandomString(seedLength);
        public static string Putiry;
        public static string Categories;

    }
}
