using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MetricsAgent.Controllers
{
    public class DotnetMetricController : Controller
    {
        private readonly ILogger<DotnetMetricController> _logger;
        public DotnetMetricController(ILogger<DotnetMetricController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в CpuMetricsController");
        }

        [HttpGet("api/metrics/dotnet/errors-count/from/{fromTime}/to/{toTime}")]
        public IActionResult GetDotnetMetrics(
            [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Get dotnet metrics");
            return Ok();
        }
    }
}
