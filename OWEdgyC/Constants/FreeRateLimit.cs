using OWEdgyC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Constants
{
    public class FreeRateLimit : BaseOpenWeatherRateLimit
    {
        public FreeRateLimit() {
            GeneralPerMinute = new KeyValuePair<int, RateLimitPeriod>(60, RateLimitPeriod.Minute);
            GeneralPerMonth = new KeyValuePair<long, RateLimitPeriod>(1000000, RateLimitPeriod.Month);
            MinuteForecast = new KeyValuePair<int, RateLimitPeriod>(1000, RateLimitPeriod.Day);
            HourlyForecast = new KeyValuePair<int, RateLimitPeriod>(1000, RateLimitPeriod.Day);
            DailyForecast = new KeyValuePair<int, RateLimitPeriod>(1000, RateLimitPeriod.Day);
            NationalWeatherAlerts = new KeyValuePair<int, RateLimitPeriod>(1000, RateLimitPeriod.Day);
            HistoricalWeather = new KeyValuePair<int, RateLimitPeriod>(1000, RateLimitPeriod.Day);
        }
    }
}
