using OWEdgyC.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Configurations
{
    public sealed class OpenWeatherConfiguration {
        internal string Token = "";
        internal Subscription Subscription;

        public OpenWeatherConfiguration(string token, Subscription subscription) {
            if(string.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException("Token cannot be null, empty, or all whitespace.");

            Token = token.Trim();
            Subscription = subscription;
        }
    }
}
