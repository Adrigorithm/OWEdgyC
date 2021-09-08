using OWEdgyC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Constants
{
    /// <summary>
    /// This class is used to generate ratelimits based on subscription plan.\n
    /// This should be up-to-date with information here:\n
    /// https://openweathermap.org/price
    /// </summary>
    public abstract class BaseOpenWeatherRateLimit
    {
        protected KeyValuePair<int, RateLimitPeriod> GeneralPerMinute;
        protected KeyValuePair<long, RateLimitPeriod> GeneralPerMonth;
        protected KeyValuePair<int, RateLimitPeriod> MinuteForecast = new(-1, RateLimitPeriod.None);
        protected KeyValuePair<int, RateLimitPeriod> HourlyForecast = new(-1, RateLimitPeriod.None);
        protected KeyValuePair<int, RateLimitPeriod> DailyForecast = new(-1, RateLimitPeriod.None);
        protected KeyValuePair<int, RateLimitPeriod> NationalWeatherAlerts = new(-1, RateLimitPeriod.None);
        protected KeyValuePair<int, RateLimitPeriod> HistoricalWeather = new(-1, RateLimitPeriod.None);
    }
}
