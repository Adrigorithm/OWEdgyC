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
        private int _currentGeneralPerMinute = 0;
        private long _currentGeneralPerMonth = 0;
        private int? _currentMinuteForecast;
        private int? _currentHourlyForecast;
        private int? _currentDailyForecast;
        private int? _currentNationalWeatherAlerts;
        private int? _currentHistoricalWeather;

        protected KeyValuePair<int, RateLimitPeriod> GeneralPerMinute;
        protected KeyValuePair<long, RateLimitPeriod> GeneralPerMonth;
        protected KeyValuePair<int, RateLimitPeriod> MinuteForecast = new(-1, RateLimitPeriod.None);
        protected KeyValuePair<int, RateLimitPeriod> HourlyForecast = new(-1, RateLimitPeriod.None);
        protected KeyValuePair<int, RateLimitPeriod> DailyForecast = new(-1, RateLimitPeriod.None);
        protected KeyValuePair<int, RateLimitPeriod> NationalWeatherAlerts = new(-1, RateLimitPeriod.None);
        protected KeyValuePair<int, RateLimitPeriod> HistoricalWeather = new(-1, RateLimitPeriod.None);

        public int CurrentGeneralPerMinute {
            get => _currentGeneralPerMinute;
            set => _currentGeneralPerMinute = value < 0 ? throw new ArgumentException(nameof(value), "Global minutely ratelimit reached.") : value;
        }
        public long CurrentGeneralPerMonth {
            get => _currentGeneralPerMonth;
            set => _currentGeneralPerMonth = value < 0 ? throw new ArgumentException(nameof(value), "Global monthly ratelimit reached.") : value;
        }
        public int? CurrentMinuteForecast {
            get => _currentMinuteForecast;
            set => _currentMinuteForecast = value < 0 ? throw new ArgumentException(nameof(value), "Minutely forecast ratelimit reached.") : value;
        }
        public int? CurrentHourlyForecast {
            get => _currentHourlyForecast;
            set => _currentHourlyForecast = value < 0 ? throw new ArgumentException(nameof(value), "Hourly forecast ratelimit reached.") : value;
        }
        public int? CurrentDailyForecast {
            get => _currentDailyForecast;
            set => _currentDailyForecast = value < 0 ? throw new ArgumentException(nameof(value), "Daily forecast ratelimit reached.") : value;
        }
        public int? CurrentNationalWeatherAlerts {
            get => _currentNationalWeatherAlerts;
            set => _currentNationalWeatherAlerts = value < 0 ? throw new ArgumentException(nameof(value), "Weather alters ratelimit reached.") : value;
        }
        public int? CurrentHistoricalWeather {
            get => _currentHistoricalWeather;
            set => _currentHistoricalWeather = value < 0 ? throw new ArgumentException(nameof(value), "Historical weather ratelimit reached.") : value;
        }
    }
}
