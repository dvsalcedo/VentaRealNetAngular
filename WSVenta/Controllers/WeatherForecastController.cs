﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WSVenta.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            List<WeatherForecast> lst = new List<WeatherForecast>();
            lst.Add(new WeatherForecast() { Id = 1, Nombre = "Pepe" });
            lst.Add(new WeatherForecast() { Id = 2, Nombre = "David" });
            return lst;
        }
    }
}
