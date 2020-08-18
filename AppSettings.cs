using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using wallpaper_forms.Models;
using wallpaper_forms.Services;

namespace wallpaper_forms
{
    public class AppSettings
    {
        private static int seedLength => 6;
        private static string fileName => "settings.json";
        private static string settingsPath => Directory.GetCurrentDirectory() + "\\" + fileName;
        public static string Page => "1";
        public static string WallhavenUri => "https://wallhaven.cc/api/v1/search";
        public static string Seed => RandomSeedService.RandomString(seedLength);
        private static string DefaultResolution => "2560x1440";
        private static string DefaultRatio => "16x9";

        public static string Putiry;
        public static string Categories;

        public static string DirectoryPath { get; set; }

        public static string LeastResolution { get; set; }
        public static string Ratio { get; set; }

        public static async Task Save(string path, string ratio, string resolution)
        {
            DirectoryPath = path;
            Ratio = ratio;
            LeastResolution = resolution;

            await SaveToFile();
        }

        private static async Task SaveToFile()
        {

            StoredSettings storedSettings = new StoredSettings() { Path = DirectoryPath, Ratio = Ratio, Resolution = LeastResolution };

            try
            {
                if (File.Exists(settingsPath))
                {
                    File.Delete(settingsPath);
                }

                var serializerOptions = new JsonSerializerOptions();
                serializerOptions.WriteIndented = true;
                var serializedSettings = JsonSerializer.Serialize<StoredSettings>(storedSettings, serializerOptions);
                await File.WriteAllTextAsync(settingsPath, serializedSettings.ToString());

            }
            catch (Exception e)
            {
                MessageBoxService.Show($"Saving settings failed: {e}");
            }

        }

        public static void LoadFromFile()
        {
            using (StreamReader r = new StreamReader(settingsPath))
            {
                string json = r.ReadToEnd();
                StoredSettings settings = JsonSerializer.Deserialize<StoredSettings>(json);
                DirectoryPath = settings.Path;
                LeastResolution = settings.Resolution;
                Ratio = settings.Ratio;
            }
        }

        public static async Task CreateDefaultOnStartup()
        {
            StoredSettings storedSettings = new StoredSettings() { Path = settingsPath, Ratio = DefaultRatio, Resolution = DefaultResolution};

            try
            {
                if (File.Exists(settingsPath))
                {
                    return;
                }

                var serializerOptions = new JsonSerializerOptions();
                serializerOptions.WriteIndented = true;
                var serializedSettings = JsonSerializer.Serialize<StoredSettings>(storedSettings, serializerOptions);
                await File.WriteAllTextAsync(settingsPath, serializedSettings.ToString());

            }
            catch (Exception e)
            {
                MessageBoxService.Show($"Creating settings file failed: {e}");
            }
        }

    }
}
