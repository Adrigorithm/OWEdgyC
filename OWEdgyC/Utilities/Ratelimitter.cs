using OWEdgyC.Constants;
using OWEdgyC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OWEdgyC.Utilities
{
    public class Ratelimitter {
        private DateTime _startPeriod;
        private Timer _timer;
        public BaseOpenWeatherRateLimit RateLimit;
        
        private void TimerProc(object state) {
            throw new NotImplementedException();
        }

        public void SetRateLimits(Subscription subscription) {
            switch(subscription){
                case Subscription.Free:
                RateLimit = new FreeRateLimit();
                break;
                
                case Subscription.Startup:
                RateLimit = new StartupRateLimit();
                break;

                case Subscription.Developer:
                RateLimit = new DeveloperRateLimit();
                break;

                case Subscription.Professional:
                RateLimit = new ProfessionalRateLimit();
                break;

                case Subscription.Enterprise:
                RateLimit = new EnterpriseRateLimit();
                break;
            }

            _timer = new Timer(new TimerCallback(TimerProc));
            _ = _timer.Change(0, 1000);

            _startPeriod = DateTime.UtcNow;
        }
    }
}
