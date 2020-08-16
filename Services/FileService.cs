using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace wallpaper_forms.Services
{
    public static class FileService
    {

        private static string sourcePath = @"";

        public static int SaveImage(Image img, string fileName)
        {
            sourcePath = fileName;
            string targetPath = AppSettings.DirectoryPath + "\\" + fileName;
            img.Save(sourcePath);


            try
            {
                if (!File.Exists(sourcePath))
                {
                    MessageBoxService.Show("Error: No image to save");
                    return -1;
                }

                // Ensure that the target does not exist.
                if (File.Exists(targetPath))
                {
                    MessageBoxService.Show("Image saved already");
                    return 0;
                }

                // Move the file.
                File.Move(sourcePath, targetPath);
                return 0;
            }
            catch (Exception e)
            {
                MessageBoxService.Show($"The process failed: {e}");
                return -1;
            }
        }
    }
}
