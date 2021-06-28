using System;
using Xunit;
using MetricsAgent.Controllers;
using Microsoft.AspNetCore.Mvc;
using MetricsAgent.DAL;
using MetricsAgent.Models;
using Moq;

namespace MetricsAgentTests
{
    public class MetricsAgentUnitTest
    {
        CpuMetricsController controllerCPU;

        public class CpuMetricsControllerUnitTests
        {
            private CpuMetricsController controllerCPU;
            private Mock<ICpuMetricsRepository> mock;

            public CpuMetricsControllerUnitTests()
            {
                mock = new Mock<ICpuMetricsRepository>();

                controllerCPU = new CpuMetricsController(mock.Object);
            }

            [Fact]
            public void Create_ShouldCall_Create_From_Repository()
            {
                // ������������� �������� ��������
                // � �������� ����������� ��� � ����������� �������� CpuMetric ������
                mock.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();

                // ��������� �������� �� �����������
                var result = controllerCPU.Create(new MetricsAgent.Requests.CpuMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });

                // ��������� �������� �� ��, ��� ���� ������� ����������
                // ������������� �������� ����� Create ����������� � ������ ����� ������� � ���������
                mock.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.AtMostOnce());
            }
        }
    }

}

