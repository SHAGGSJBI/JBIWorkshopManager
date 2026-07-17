using JBI.WorkshopManager.UI.Navigation;
using JBI.WorkshopManager.UI.ViewModels;
using JBI.WorkshopManager.UI.Views;
using JBI.WorkshopManager.UI.Windows;
using JBIWorkshopManager.Core.Interfaces;
using JBIWorkshopManager.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace JBI.WorkshopManager.UI.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUIServices(this IServiceCollection services)
    {
        // Navigation
        services.AddSingleton<INavigationService, NavigationService>();
        services.AddSingleton<NavigationRegistry>();

        // Repositories
        services.AddSingleton<IMachineRepository, InMemoryMachineRepository>();

        // ViewModels
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<DashboardViewModel>();
        services.AddTransient<MachineCatalogueViewModel>();

        // Windows
        services.AddSingleton<MainWindow>();
        services.AddTransient<MachineCatalogueView>();

        return services;
    }
}