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

            CurrentGeneralPerMinute = 60;
            CurrentGeneralPerMonth = 1000000;
            CurrentMinuteForecast = 1000;
            CurrentHourlyForecast = 1000;
            CurrentDailyForecast = 1000;
            CurrentNationalWeatherAlerts = 1000;
            CurrentHistoricalWeather = 1000;
        }
    }
}
