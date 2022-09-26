using FalseNegativeInvestigation.Application;
using FalseNegativeInvestigation.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplicationBindings()
    .AddInfrastructureBindings(builder.Configuration);

var app = builder.Build();

var serviceProvider = app.Services.CreateScope().ServiceProvider;

var processor = serviceProvider.GetService<Processor>()!;

Console.WriteLine("Enter your SQL:");
var untrustedValue = Console.ReadLine()!;
processor.Process(untrustedValue);
