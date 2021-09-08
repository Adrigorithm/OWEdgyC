using OWEdgyC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Constants
{
    public class ProfessionalRateLimit : BaseOpenWeatherRateLimit
    {
        public ProfessionalRateLimit() {
            GeneralPerMinute = new KeyValuePair<int, RateLimitPeriod>(30000, RateLimitPeriod.Minute);
            GeneralPerMonth = new KeyValuePair<long, RateLimitPeriod>(1000000000, RateLimitPeriod.Month);
        }
    }
}
