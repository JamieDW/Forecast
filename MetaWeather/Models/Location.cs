using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MetaWeather.Models
{
    public class Location
    {
        [JsonPropertyName("consolidated_weather")]
        public ConsolidatedWeather[] ConsolidatedWeather { get; set; }

        [JsonPropertyName("time")]
        public DateTime Time { get; set; }

        [JsonPropertyName("sun_rise")]
        public DateTime Sunrise { get; set; }

        [JsonPropertyName("sun_set")]
        public DateTime Sunset { get; set; }

        [JsonPropertyName("timezone_name")]
        public string TimezoneName { get; set; }

        [JsonPropertyName("parent")]
        public LocationSearch Parent { get; set; }

        [JsonPropertyName("sources")]
        public Source[] Sources { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("location_type")]
        public string LocationType { get; set; }

        [JsonPropertyName("latt_long")]
        public string Coordinates { get; set; }

        [JsonPropertyName("woeid")]
        public int WoeID { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }
    }
}
