using System;
using System.Collections.Generic;
using System.Text;
using wallpaper_forms.Services;

namespace wallpaper_forms
{
    public class AppSettings
    {
        private static int seedLength => 6;
        public static string Page => "1";
        public static string WallhavenUri => "https://wallhaven.cc/api/v1/search";
        public static string Seed => RandomSeedService.RandomString(seedLength);
        public static string DefaultResolution => "2560x1440";
        public static string DefaultRatio => "16x9";

        public static string Putiry;
        public static string Categories;

        public static string DirectoryPath = "D:\\Cloud\\Tapety\\App\\";
        
        public static string LeastResolution = "2560x1440";
        public static string Ratio = "16x9";

        public static void Save(string path, string ratio, string resolution)
        {
            DirectoryPath = path;
            Ratio = ratio;
            LeastResolution = resolution;
            // ToDo: save to file
        }
        public static void Load()
        {
            // ToDo: load from file
        }
    }
}
