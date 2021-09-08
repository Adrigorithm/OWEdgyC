using OWEdgyC.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWEdgyC.Clients
{
    public abstract class BaseOpenWeatherClient : IDisposable {
        readonly protected OpenWeatherConfiguration Configuration;

        /// <summary>
        /// Base constrcutor for an OpenWeatherClient doing necessary initial configuration(s)
        /// </summary>
        /// <param name="config">Use a valid subscription corresponding to the given token.\n
        /// Not doing this might get your token locked or even banned due to the library using wrong ratelimits.\n
        /// You've been warned.</param>
        protected BaseOpenWeatherClient(OpenWeatherConfiguration config) =>
            Configuration = config;


        /// <summary>
        /// Disposes this client.
        /// </summary>
        public abstract void Dispose();
    }
}
