using System;
using Xunit;
using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsAgentTests
{
    public class MetricsAgentUnitTest
    {
        CpuMetricsController controllerCPU;
        DotnetMetricController controllerDotNet;
        NetworkMetricController controllerNetwork;
        HddMetricController controllerHDD;
        RamMetricController controllerRAM;
        

        public MetricsAgentUnitTest()
        {
            controllerCPU = new CpuMetricsController();
            controllerDotNet = new DotnetMetricController();
            controllerNetwork = new NetworkMetricController();
            controllerHDD = new HddMetricController();
            controllerRAM = new RamMetricController();
        }

        [Fact]
        public void GetCPUMetricsPercentile_ReturnsOk()
        {
            //Arrange
            var percentile = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            //Act
            var result = controllerCPU.GetCPUMetrics(fromTime, toTime, percentile);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetCPUMetrics_ReturnsOk()
        {
            //Arrange
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            //Act
            var result = controllerCPU.GetCPUMetrics(fromTime, toTime);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetDotnetMetrics_ReturnsOk()
        {
            //Arrange
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            //Act
            var result = controllerDotNet.GetDotnetMetrics(fromTime, toTime);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetNetworkMetrics_ReturnsOk()
        {
            //Arrange
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            //Act
            var result = controllerNetwork.GetNetworkMetrics(fromTime, toTime);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetHddLeftMetrics_ReturnsOk()
        {
            //Act
            var result = controllerHDD.GetHddLeftMetrics();
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetRamAvailableMetrics_ReturnsOk()
        {
            //Act
            var result = controllerRAM.GetRamAvailableMetrics();
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }

}

