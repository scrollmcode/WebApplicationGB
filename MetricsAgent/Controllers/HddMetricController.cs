using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MetricsAgent.Controllers
{
    public class HddMetricController : Controller
    {
        private readonly ILogger<HddMetricController> _logger;
        public HddMetricController(ILogger<HddMetricController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в CpuMetricsController");
        }

        [HttpGet("api/metrics/hdd/left")]
        public IActionResult GetHddLeftMetrics()
        {
            _logger.LogInformation("Get hdd metrics");
            return Ok();
        }
    }
}
