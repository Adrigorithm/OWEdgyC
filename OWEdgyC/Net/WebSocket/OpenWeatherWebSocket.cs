using OWEdgyC.Configurations;
using OWEdgyC.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace OWEdgyC.Net.WebSocket
{
    #region Configuration
    public partial class OpenWeatherWebSocket
    {
        private OpenWeatherConfiguration _config;
        private HttpClient _webClient;
        private Ratelimitter _rateLimitter;

        public OpenWeatherWebSocket(OpenWeatherConfiguration config) {
            _config = config;

            _webClient = new HttpClient();

            _rateLimitter = new Ratelimitter();
            _rateLimitter.SetRateLimits(_config.Subscription);
        }
    }
    #endregion

    #region API Calls 1
    public partial class OpenWeatherWebSocket
    {
        public async Task GetCurrentWeatherByCity(string city){
            _ = await _webClient.GetAsync("");

            _rateLimitter.RateLimit.CurrentGeneralPerMonth -= 1;
            _rateLimitter.RateLimit.CurrentGeneralPerMinute -= 1;
        }
    }
    #endregion
}
