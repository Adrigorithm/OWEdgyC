using OWEdgyC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Constants
{
    public class EnterpriseRateLimit : BaseOpenWeatherRateLimit
    {
        public EnterpriseRateLimit() {
            GeneralPerMinute = new KeyValuePair<int, RateLimitPeriod>(200000, RateLimitPeriod.Minute);
            GeneralPerMonth = new KeyValuePair<long, RateLimitPeriod>(5000000000, RateLimitPeriod.Month);

            CurrentGeneralPerMinute = 200000;
            CurrentGeneralPerMonth = 5000000000;
        }
    }
}
