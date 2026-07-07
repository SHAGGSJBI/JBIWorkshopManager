using JBI.WorkshopManager.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using JBI.WorkshopManager.UI.Windows;

namespace JBI.WorkshopManager.UI.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUIServices(this IServiceCollection services)
    {
        // ViewModels
        services.AddSingleton<MainViewModel>();

        // Windows
        services.AddSingleton<MainWindow>();

        return services;
    }
}