using System;
using System.Collections.Generic;
using System.Text;

namespace wallpaper_forms.Models
{

    public class Meta
    {
        public int CurrentPage { get; set; }
        public int LastPage { get; set; }
        public int PerPage { get; set; }
        public int Total { get; set; }
        public object Query { get; set; }
        public object Seed { get; set; }
    }
}