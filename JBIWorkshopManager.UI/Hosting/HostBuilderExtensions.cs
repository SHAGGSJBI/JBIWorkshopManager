using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace JBI.WorkshopManager.UI.Hosting;

public static class HostBuilderExtensions
{
    public static IHostBuilder ConfigureWorkshopManager(this IHostBuilder builder)
    {
        builder.ConfigureAppConfiguration(config =>
        {
            config.AddJsonFile("appsettings.json",
                               optional: false,
                               reloadOnChange: true);
        });

        builder.UseSerilog((context, services, configuration) =>
        {
            configuration.ReadFrom.Configuration(context.Configuration);
        });

        builder.ConfigureServices((context, services) =>
        {
            // Infrastructure registrations
            // Core registrations
            // UI registrations
        });

        return builder;
    }
}