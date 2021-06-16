using System;
using System.Threading.Tasks;
using System.Threading;
using WorkerServicesDemo.Controllers;
using Microsoft.Extensions.Hosting;

namespace WorkerServicesDemo
{
    public class ClearTableService : IHostedService
    {
        private readonly TimeSpan _timerInterval = TimeSpan.FromSeconds(10);
        private Timer _timer;

        public ClearTableService()
        {

        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(state => Demo.ClearTable(), null, TimeSpan.Zero, _timerInterval);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}

