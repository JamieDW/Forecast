using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MetaWeather.Models
{
    public class Source
    {
        /// <summary>
        /// title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// slug
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// url
        /// </summary>
        [JsonPropertyName("url")]   
        public string Url { get; set; }

        /// <summary>
        /// crawl rate
        /// </summary>
        [JsonPropertyName("crawl_rate")]
        public int CrawlRate { get; set; }
    }
}
