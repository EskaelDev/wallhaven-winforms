using System.Text.Json.Serialization;

namespace wallpaper_forms.Models
{
    public class WallhavenRequest
    {
        [JsonPropertyName("q")]
        public string Q { get; set; }

        /// <summary>100/101/111*/etc (general/anime/people)</summary> 

        [JsonPropertyName("categories")]
        public string Categories { get; set; }

        /// <summary>100*/110/111/etc(sfw/sketchy/nsfw)</summary> 

        [JsonPropertyName("purity")]
        public string Purity { get; set; }

        /// <summary>date_added*, relevance, random, views, favorites, toplist</summary> 

        [JsonPropertyName("sorting")]
        public string Sorting { get; set; }

        /// <summary>desc*, asc</summary> 

        [JsonPropertyName("order")]
        public string Order { get; set; }

        /// <summary>1d, 3d, 1w,1M*, 3M, 6M, 1y</summary> 

        [JsonPropertyName("topRange")]
        public string TopRange { get; set; }

        /// <summary>1920x1080</summary> 

        [JsonPropertyName("atleast")]
        public string AtLeast { get; set; }

        /// <summary>1920x1080,1920x1200</summary> 

        [JsonPropertyName("resolutions")]
        public string Resolutions { get; set; }

        /// <summary>16x9,16x10</summary> 

        [JsonPropertyName("ratios")]
        public string Ratios { get; set; }

        /// <summary>660000 990000 cc0000 cc3333 ea4c88 993399 663399 333399 0066cc 0099cc 66cccc 77cc33 669900 336600 
        /// 666600 999900 cccc33 ffff00 ffcc33 ff9900 ff6600 cc6633 996633 663300 000000 999999 cccccc ffffff 424153</summary> 

        [JsonPropertyName("colors")]
        public string Colors { get; set; }


        /// <summary>1-30</summary> 

        [JsonPropertyName("page")]
        public string Page { get; set; }

        /// <summary>[a-zA-Z0-9]{6}</summary> 

        [JsonPropertyName("seed")]
        public string Seed { get; set; }
    }
}
