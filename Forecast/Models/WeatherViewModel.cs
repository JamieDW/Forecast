using MetaWeather.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forecast.Models
{    public class WeatherViewModel
    {
        /// <summary>
        /// The constructor for the WeatherViewModel
        /// </summary>
        /// <param name="consolidatedWeather"></param>
        public WeatherViewModel(ConsolidatedWeather consolidatedWeather)
        {
            this.Day = consolidatedWeather.ApplicableDate;
            this.Date = consolidatedWeather.ApplicableDate;
            this.WindSpeed = consolidatedWeather.WindSpeed;
            this.MinTemp = consolidatedWeather.MinTemp;
            this.MaxTemp = consolidatedWeather.MaxTemp;
            this.CurrentTemp = consolidatedWeather.TheTemp;
            this.AirPressure = consolidatedWeather.AirPressure;
            this.Humidity = consolidatedWeather.Humidity;
            this.Predictability = consolidatedWeather.Predictability;
            this.IconUrl = consolidatedWeather.IconUrl;
        }

        /// <summary>
        /// A formatted date which returns the day
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dddd}")]
        public DateTime Day { get; set; }

        /// <summary>
        /// A formatted date which returns the day and month
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dd/MM}")]
        public DateTime Date { get; set; }

        /// <summary>
        /// A formatted float which represents the wind speed of the weather
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:0}")]
        public float WindSpeed { get; set; }

        /// <summary>
        /// A formatted float which represents the min temp of the weather
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:0}")]
        public float MinTemp { get; set; }

        /// <summary>
        /// A formatted float which represents the max temp of the weather
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:0}")]
        public float MaxTemp { get; set; }

        /// <summary>
        /// A formatted float which represents the current temp of the weather
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:0}")]
        public float CurrentTemp { get; set; }

        /// <summary>
        /// A formatted float which represents the air pressure of the weather
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:0}")]
        public float AirPressure { get; set; }

        /// <summary>
        /// A formatted float which represents the humidity of the weather
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:0}")]
        public float Humidity { get; set; }

        /// <summary>
        /// The predictability of the weather
        /// </summary>
        public int Predictability { get; set; }

        /// <summary>
        /// The icon to use for the weather
        /// </summary>
        public string IconUrl { get; set; }
    }
}
