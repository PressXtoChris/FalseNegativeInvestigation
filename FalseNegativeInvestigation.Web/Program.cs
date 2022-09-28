using System;
using FalseNegativeInvestigation.Application;
using FalseNegativeInvestigation.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FalseNegativeInvestigation.Web
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
            {
                services
                    .AddApplicationBindings()
                    .AddInfrastructureBindings(context.Configuration);
            });

            var app = builder.Build();

            var serviceProvider = app.Services.CreateScope().ServiceProvider;

            var processor = serviceProvider.GetService<Processor>()!;

            Console.WriteLine("Enter your SQL:");
            var untrustedValue = Console.ReadLine()!;
            processor.Process(untrustedValue);
        }
    }
}
