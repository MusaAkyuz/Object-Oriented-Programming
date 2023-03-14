using WorkerServiceFirstLookup;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging.EventLog;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddWindowsService(t => t.ServiceName = ".NET Joket Service");

LoggerProviderOptions.RegisterProviderOptions<EventLogSettings, EventLogLoggerProvider>(builder.Services);

builder.Services.AddSingleton<JokeService>();
builder.Services.AddHostedService<WindowsBackgroundService>();

builder.Logging.AddConfiguration(builder.Configuration.GetSection("Logging"));

IHost host = builder.Build();
host.Run();
