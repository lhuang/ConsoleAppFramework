﻿using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    internal class EmptyHostedService : IHostedService
    {
        readonly IHostApplicationLifetime appLifetime;

        public EmptyHostedService(IHostApplicationLifetime appLifetime)
        {
            this.appLifetime = appLifetime;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            this.appLifetime.StopApplication();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
