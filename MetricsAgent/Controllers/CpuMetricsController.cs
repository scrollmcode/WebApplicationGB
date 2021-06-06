using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers
{
    public class CpuMetricsController : Controller
    {
        [HttpGet("api/metrics/cpu/from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
        public IActionResult GetCPUMetrics(
            [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] int percentile)
        {
            return Ok();
        }

        [HttpGet("api/metrics/cpu/from/{fromTime}/to/{toTime}/")]
        public IActionResult GetCPUMetrics(
            [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }

    }
}
