using JBI.WorkshopManager.UI.Navigation;
using JBI.WorkshopManager.UI.ViewModels;
using JBI.WorkshopManager.UI.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace JBI.WorkshopManager.UI.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUIServices(this IServiceCollection services)
    {
        // Services
        services.AddSingleton<INavigationService, NavigationService>();

        // ViewModels
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<DashboardViewModel>();

        // Windows
        services.AddSingleton<MainWindow>();

        return services;
    }
}