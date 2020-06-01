using MetaWeather.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MetaWeather.Interfaces
{
    /// <summary>
    /// interface to have the required method to call the REST API
    /// </summary>
    public interface IRestService
    {
        /// <summary>
        /// get data and deserialize them
        /// </summary>
        /// <param name="location">the location to perform the request</param>
        /// <returns>LocationSearch object</returns>
        Task<LocationSearch> GetLocationSearchAsync(string location);

        /// <summary>
        /// get data and deserialize them
        /// </summary>
        /// <param name="woeid">the woeid to perform the request</param>
        /// <returns>Location object</returns>
        Task<Location> GetLocationAsync(int woeid);
    }    
}
