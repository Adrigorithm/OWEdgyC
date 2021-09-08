using OWEdgyC.Configurations;
using OWEdgyC.Net.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Clients
{
    public sealed class OpenWeatherClient : BaseOpenWeatherClient
    {
        private OpenWeatherWebSocket _webSocket;
        public OpenWeatherClient(OpenWeatherConfiguration config) : base(config) {
            _webSocket = new OpenWeatherWebSocket();
        }

        ~OpenWeatherClient() {
            Dispose();
        }

        public async Task GetCurrentWeatherAsync(string city) {

        }

        public override void Dispose() { }
    }
}
