using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MetaWeather.Models
{
    public class LocationSearch
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("location_type")]
        public string LocationType { get; set; }

        [JsonPropertyName("latt_long")]   
        public string Coordinates { get; set; }

        [JsonPropertyName("woeid")]
        public int WoeID { get; set; }
    }
}
