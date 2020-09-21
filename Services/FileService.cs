using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace wallpaper_forms.Services
{
    public class FileService : IFileService
    {
        private readonly ILogger<RequestService> _log;
        private readonly IConfiguration _config;
        private readonly IMessageBoxService _messageBoxService;
        private string sourcePath = @"";

        public FileService(ILogger<RequestService> log, IConfiguration config, IMessageBoxService messageBoxService)
        {
            _log = log;
            _config = config;
            _messageBoxService = messageBoxService;
        }


        public int SaveImage(Image img, string fileName)
        {
            sourcePath = fileName;
            string targetPath = AppConfiguration.DirectoryPath + "\\" + fileName;
            img.Save(sourcePath);


            try
            {
                _log.LogDebug("Saving image at: {targetPath}", targetPath);
                if (!File.Exists(sourcePath))
                {
                    _messageBoxService.Show("Error: No image to save");
                    return -1;
                }

                // Ensure that the target does not exist.
                if (File.Exists(targetPath))
                {
                    _messageBoxService.Show("Image saved already");
                    return 0;
                }

                // Move the file.
                File.Move(sourcePath, targetPath);
                _log.LogDebug("Image saved ✅");
                return 0;
            }
            catch (Exception e)
            {
                _messageBoxService.Show($"The process failed: {e}");
                return -1;
            }
        }
    }
}
