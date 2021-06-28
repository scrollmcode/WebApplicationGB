using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MetricsAgent.Controllers
{
    public class RamMetricController : Controller
    {
        private readonly ILogger<RamMetricController> _logger;
        public RamMetricController(ILogger<RamMetricController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в CpuMetricsController");
        }

        [HttpGet("api/metrics/ram/available")]
        public IActionResult GetRamAvailableMetrics()
        {
            _logger.LogInformation("Get ram metrics");
            return Ok();
        }
    }
}
