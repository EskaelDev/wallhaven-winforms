using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wallpaper_forms.Services
{
    public static class RandomSeedService
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
