using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MetricsAgent.Controllers
{
    public class NetworkMetricController : Controller
    {
        private readonly ILogger<NetworkMetricController> _logger;
        public NetworkMetricController(ILogger<NetworkMetricController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в CpuMetricsController");
        }

        [HttpGet("api/metrics/network/from/{fromTime}/to/{toTime}/")]
        public IActionResult GetNetworkMetrics(
            [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Get network metrics");
            return Ok();
        }
    }
}
