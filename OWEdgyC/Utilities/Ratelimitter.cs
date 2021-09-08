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
        private Timer _timer;
        private Subscription _subscription;
        
        public Ratelimitter() {
            _timer = new Timer(new TimerCallback(TimerProc));
            _ = _timer.Change(0, 1000);
        }

        private void TimerProc(object state) {
            throw new NotImplementedException();
        }

        public void SetRateLimits(Subscription subscription) {
            _subscription = subscription;
        }
    }
}
