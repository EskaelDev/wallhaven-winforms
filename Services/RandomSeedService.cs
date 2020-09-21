using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wallpaper_forms.Services
{
    public class RandomSeedService : IRandomSeedService
    {
        private Random random = new Random();
        private readonly ILogger<RequestService> _log;
        private readonly IConfiguration _config;

        public RandomSeedService(ILogger<RequestService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
