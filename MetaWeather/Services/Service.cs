using MetaWeather.Interfaces;
using MetaWeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MetaWeather
{
    /// <summary>
    /// MetaWeather class
    /// </summary>
    internal class Service : IRestService
    {
        /// <summary>
        /// the base url
        /// </summary>
        private const string BASE_URL = "https://www.metaweather.com";

        /// <summary>
        /// the location search root
        /// </summary>
        private const string LOCATION_SEARCH_ROOT = "/api/location/search/?query=";

        /// <summary>
        /// the location root
        /// </summary>
        private const string LOCATION_ROOT = "/api/location/";

        /// <summary>
        /// the weather images root
        /// </summary>
        private const string WEATHER_IMAGES_ROOT = "/static/img/weather/";

        private static HttpClient httpClient;

        /// <summary>
        /// the LocationSearchUrl to be used
        /// </summary>
        private static string LocationSearchUrl
        {
            get { return $"{BASE_URL}/{LOCATION_SEARCH_ROOT}"; }
        }

        /// <summary>
        /// the LocationUrl to be used
        /// </summary>
        private static string LocationUrl
        {
            get { return $"{BASE_URL}/{LOCATION_ROOT}"; }
        }

        /// <summary>
        /// the LocationSearchUrl to be used
        /// </summary>
        public static string WeatherImageUrl
        {
            get { return $"{BASE_URL}/{WEATHER_IMAGES_ROOT}"; }
        }

        /// <summary>
        /// the HttpClient to be used
        /// </summary>
        private static HttpClient HttpClient
        {
            get { return httpClient ?? new HttpClient(); }
        } 


        public async Task<LocationSearch> GetLocationSearchAsync(string location)
        {
            LocationSearch locationSearch = null;

            var requestUrl = $"{LocationSearchUrl}{location}";

            try
            {
                var jsonResponse = await HttpClient.GetStringAsync(requestUrl);

                locationSearch = JsonSerializer.Deserialize<List<LocationSearch>>(jsonResponse).FirstOrDefault();
            }
            catch(Exception e)
            {

            }

            return locationSearch;
        }

        public async Task<Location> GetLocationAsync(int woeid)
        {
            Location location = null;

            var requestUrl = $"{LocationUrl}{woeid}";

            try
            {
                var jsonResponse = await HttpClient.GetStringAsync(requestUrl);

                location = JsonSerializer.Deserialize<Location>(jsonResponse);
            }
            catch (Exception e)
            {

            }

            return location;
        }
    }
}
