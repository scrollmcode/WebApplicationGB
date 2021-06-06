using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers
{
    public class HddMetricController : Controller
    {
        [HttpGet("api/metrics/hdd/left")]
        public IActionResult GetHddLeftMetrics()
        {
            return Ok();
        }
    }
}
