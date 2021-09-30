using OWEdgyC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Constants
{
    public class DeveloperRateLimit : BaseOpenWeatherRateLimit
    {
        public DeveloperRateLimit() {
            GeneralPerMinute = new KeyValuePair<int, RateLimitPeriod>(3000, RateLimitPeriod.Minute);
            GeneralPerMonth = new KeyValuePair<long, RateLimitPeriod>(100000000, RateLimitPeriod.Month);

            CurrentGeneralPerMinute = 3000;
            CurrentGeneralPerMonth = 100000000;
        }
    }
}
