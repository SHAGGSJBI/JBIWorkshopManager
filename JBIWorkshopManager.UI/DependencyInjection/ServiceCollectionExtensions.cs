using JBI.WorkshopManager.UI.Features.Dashboard;
using JBI.WorkshopManager.UI.Navigation;
using JBI.WorkshopManager.UI.ViewModels;
using JBI.WorkshopManager.UI.ViewModels.WorkOrders;
using JBI.WorkshopManager.UI.Views;
using JBI.WorkshopManager.UI.Views.WorkOrders;
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
        services.AddSingleton<IWorkOrderRepository, InMemoryWorkOrderRepository>();

        // ViewModels
        services.AddSingleton<MainViewModel>();
        services.AddSingleton<DashboardViewModel>();

        services.AddTransient<WorkOrderListViewModel>();
        services.AddTransient<NewWorkOrderViewModel>();
        services.AddTransient<MachineCatalogueViewModel>();

        // Views
        services.AddTransient<NewWorkOrderView>();
        services.AddTransient<MachineCatalogueView>();

        // Windows
        services.AddSingleton<MainWindow>();

        return services;
    }
}