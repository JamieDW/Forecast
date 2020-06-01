using MetaWeather.Interfaces;
using MetaWeather.Models;
using System.Threading.Tasks;

namespace MetaWeather
{
    /// <summary>
    /// MetaWeather class
    /// </summary>
    public class Weather
    {
        /// <summary>
        /// the rest service to perform our web calls
        /// </summary>
        public IRestService Service { get; set; }

        /// <summary>
        /// default constructor that uses the default IRestService implementation
        /// </summary> 
        public Weather()
        {
            Service = new Service();
        }

        /// <summary>
        /// get weather data by location
        /// </summary>
        /// <param name="location">location</param>
        /// <returns>LocationSearch</returns>
        public async Task<LocationSearch> GetWeatherByLocationSearch(string location)
        {
            return await Service.GetLocationSearchAsync(location);
        }

        /// <summary>
        /// get weather data by WOEID (where on earch identifier)
        /// </summary>
        /// <param name="woeid">where on earth identifier</param>
        /// <returns>WeatherData</returns>
        public async Task<Location> GetWeatherByLocation(int woeid)
        {
            return await Service.GetLocationAsync(woeid);
        }
    }
}
