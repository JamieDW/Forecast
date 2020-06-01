using MetaWeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forecast.Models
{
    public class ForecastViewModel
    {
        /// <summary>
        /// The constructor for the ForecastViewModel
        /// </summary>
        /// <param name="location"></param>
        public ForecastViewModel(Location location)
        {
            this.Location = location.Title;

            this.CurrentWeather = new WeatherViewModel(location.ConsolidatedWeather.FirstOrDefault());

            this.FutureWeathers = location.ConsolidatedWeather
                .Skip(1)
                .Select(cw => new WeatherViewModel(cw))
                .ToArray();
        }

        /// <summary>
        /// The Location of the forecast
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// The forecast for today
        /// </summary>
        public WeatherViewModel CurrentWeather { get; set; }

        /// <summary>
        /// The next five days forecast
        /// </summary>
        public WeatherViewModel[] FutureWeathers { get; set; }
    }
}
