using OWEdgyC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Constants
{
    public class APIBaseUri
    {
        public readonly Uri CurrentWeather = new Uri("https://api.openweathermap.org/data/2.5/weather");
        public readonly Uri HourlyForecast = new Uri("https://pro.openweathermap.org/data/2.5/forecast/hourly");
        public readonly Uri OneCallApi = new Uri("https://api.openweathermap.org/data/2.5/onecall");
        public readonly Uri OneCallApiHistorical = new Uri("https://api.openweathermap.org/data/2.5/onecall/timemachine");
        public readonly Uri DailyForecast = new Uri("https://api.openweathermap.org/data/2.5/forecast/daily");
        public readonly Uri WeatherForecast30 = new Uri("https://pro.openweathermap.org/data/2.5/forecast/climate");
        public readonly Uri BulkDownloadForecast = new Uri("https://bulk.openweathermap.org/");
        public readonly Uri SolarRadiationApi = new Uri("https://api.openweathermap.org/data/2.5/solar_radiation");
        
        // What the fuck. Why?
        public Uri GlobalWeatherAltert = new Uri("");

        public readonly Uri WorkWeek3HourForecast = new Uri("https://api.openweathermap.org/data/2.5/forecast");
        public readonly Uri RoadRiskApi = new Uri("https://api.openweathermap.org/data/2.5/roadrisk");
        public readonly Uri HourlyHistoricalWeather = new Uri("https://history.openweathermap.org/data/2.5/history/city");
        public readonly Uri HourlyHistoricalWeatherApi = new Uri("https://history.openweathermap.org/data/3.0/history/");
    }
}
