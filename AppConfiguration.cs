using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
    public class AppConfiguration
    {
        public static int seedLength => 6;
        private static string fileName => "settings.json";
        private static string settingsPath => Directory.GetCurrentDirectory() + "\\" + fileName;
        public static string Page => "1";
        public static string WallhavenUri => "https://wallhaven.cc/api/v1/search";
        //public static string Seed => RandomSeedService.RandomString(seedLength);
        private static string DefaultResolution => "2560x1440";
        private static string DefaultRatio => "16x9";

        public static string Putiry;
        public static string Categories;

        public static string DirectoryPath { get; set; }

        public static string LeastResolution { get; set; }
        public static string Ratio { get; set; }

        public static int MainFormWidth => 675;
        public static int MainFormHeight => 350;

        private static IMessageBoxService _messageBox;
        private IHost _host;
        public IHost Host
        {
            set
            {
                _host = value;
                _messageBox = ActivatorUtilities.CreateInstance<MessageBoxService>(_host.Services);
            }
        }




        public AppConfiguration()
        {

        }

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
                _messageBox.Show($"Saving settings failed: {e}");
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

            try
            {
                if (File.Exists(settingsPath))
                {
                    return;
                }
                StoredSettings storedSettings = new StoredSettings() { Path = Directory.GetCurrentDirectory(), Ratio = DefaultRatio, Resolution = DefaultResolution };

                var serializerOptions = new JsonSerializerOptions();
                serializerOptions.WriteIndented = true;
                var serializedSettings = JsonSerializer.Serialize<StoredSettings>(storedSettings, serializerOptions);
                await File.WriteAllTextAsync(settingsPath, serializedSettings.ToString());

            }
            catch (Exception e)
            {
                _messageBox.Show($"Creating settings file failed: {e}");
            }
        }

    }
}
