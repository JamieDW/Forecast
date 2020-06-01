using Forecast.Models;
using MetaWeather;
using MetaWeather.Models;
using System.Threading.Tasks;

namespace Forecast.Services
{
    /// <summary>
    /// The WeatherService Class
    /// </summary>
    public class WeatherService
    {
        /// <summary>
        /// Retrieive the forecast, for the current day and the following five days.
        /// </summary>
        /// <param name="locationName">Text to search for. Normally a city, location, or place of origin</param>
        /// <returns>ForecastViewModel</returns>
        public static ForecastViewModel GetForecast(string locationName = "Belfast")
        {
            LocationSearch locationSearch = null;
            Location location = null;

            var weather = new Weather();

            var getLocationSearch = Task.Run(async () => {
                locationSearch = await weather.GetWeatherByLocationSearch(locationName);
            });

            getLocationSearch.Wait();

            if (locationSearch != null)
            {
                var getLocation = Task.Run(async () => {
                    location = await weather.GetWeatherByLocation(locationSearch.WoeID);
                });

                getLocation.Wait();
            }

            return ParseLocation(location);
        }

        /// <summary>
        /// Parses the MetaWeather Object into a Forecast view model
        /// </summary>
        /// <param name="location">The Location object retrieved from the MetaWeather Api</param>
        /// <returns>ForecastViewModel</returns>
        /// 
        private static ForecastViewModel ParseLocation(Location location)
        {
            ForecastViewModel forecastViewModel = null;

            if (location != null)
            {
                forecastViewModel = new ForecastViewModel(location);
            }

            return forecastViewModel;
        }
    }
}
