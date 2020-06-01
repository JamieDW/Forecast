using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MetaWeather.Models
{
    public class ConsolidatedWeather
    {
        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonPropertyName("applicable_date")]
        public DateTime ApplicableDate { get; set; }

        [JsonPropertyName("weather_state_name")]
        public string WeatherStateName { get; set; }

        [JsonPropertyName("weather_state_abbr")]
        public string WeatherStateAbbreviation { get; set; }

        [JsonPropertyName("wind_speed")]
        public float WindSpeed { get; set; }

        [JsonPropertyName("wind_direction")]
        public float WindDirection { get; set; }

        [JsonPropertyName("wind_direction_compass")]
        public string WindDirectionCompass { get; set; }

        [JsonPropertyName("min_temp")]
        public float MinTemp { get; set; }

        [JsonPropertyName("max_temp")]
        public float MaxTemp { get; set; }

        [JsonPropertyName("the_temp")]
        public float TheTemp { get; set; }

        [JsonPropertyName("air_pressure")]
        public float AirPressure { get; set; }

        [JsonPropertyName("humidity")]
        public float Humidity { get; set; }

        [JsonPropertyName("visibility")]
        public float Visibility { get; set; }

        [JsonPropertyName("predictability")]
        public int Predictability { get; set; }

        public string IconUrl { get { return $"{Service.WeatherImageUrl}{WeatherStateAbbreviation}.svg"; } }
    }
}
