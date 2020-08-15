using System;
using System.Collections.Generic;
using System.Text;

namespace wallpaper_forms.Models
{
    public class Datum
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string ShortUrl { get; set; }
        public int Views { get; set; }
        public int Favorites { get; set; }
        public string Source { get; set; }
        public string Purity { get; set; }
        public string Category { get; set; }
        public int DimensionX { get; set; }
        public int DimensionY { get; set; }
        public string Resolution { get; set; }
        public string Ratio { get; set; }
        public int FileSize { get; set; }
        public string FileType { get; set; }
        public string CreatedAt { get; set; }
        public List<string> Colors { get; set; }
        public string Path { get; set; }
        public Thumbs Thumbs { get; set; }
    }
}
