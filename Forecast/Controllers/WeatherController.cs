using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forecast.Models;
using Forecast.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Forecast.Controllers
{
    public class WeatherController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            ForecastViewModel foreCast = WeatherService.GetForecast();

            return View(foreCast);
        }
    }
}
