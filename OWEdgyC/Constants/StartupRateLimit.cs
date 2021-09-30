using OWEdgyC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Constants
{
    public class StartupRateLimit : BaseOpenWeatherRateLimit
    {
        public StartupRateLimit() {
            GeneralPerMinute = new KeyValuePair<int, RateLimitPeriod>(600, RateLimitPeriod.Minute);
            GeneralPerMonth = new KeyValuePair<long, RateLimitPeriod>(10000000, RateLimitPeriod.Month);
            MinuteForecast = new KeyValuePair<int, RateLimitPeriod>(2000, RateLimitPeriod.Day);
            HourlyForecast = new KeyValuePair<int, RateLimitPeriod>(2000, RateLimitPeriod.Day);
            NationalWeatherAlerts = new KeyValuePair<int, RateLimitPeriod>(2000, RateLimitPeriod.Day);
            HistoricalWeather = new KeyValuePair<int, RateLimitPeriod>(2000, RateLimitPeriod.Day);

            CurrentGeneralPerMinute = 600;
            CurrentGeneralPerMonth = 10000000;
            CurrentMinuteForecast = 2000;
            CurrentHourlyForecast = 2000;
            CurrentNationalWeatherAlerts = 2000;
            CurrentHistoricalWeather = 2000;
        }
    }
}
