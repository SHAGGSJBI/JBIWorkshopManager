using Microsoft.Extensions.Logging;
using CommunityToolkit.Mvvm.Input;
using JBI.WorkshopManager.UI.Navigation;
using JBI.WorkshopManager.UI.ViewModels.Base;
using JBI.WorkshopManager.UI.Features.Dashboard;
using JBI.WorkshopManager.UI.ViewModels.WorkOrders;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed partial class MainViewModel : ViewModelBase
{
    private readonly ILogger<MainViewModel> _logger;
    private readonly INavigationService _navigationService;

    private string _applicationTitle = "JBI Workshop Manager";
    private ViewModelBase? _currentViewModel;

    public MainViewModel(
        ILogger<MainViewModel> logger,
        INavigationService navigationService,
        DashboardViewModel dashboardViewModel,
        WorkOrderListViewModel workOrderListViewModel)
    {
        _logger = logger;
        _navigationService = navigationService;

        NavigationItems = new List<NavigationItem>
        {
            new NavigationItem(
                "Dashboard",
                "🏠",
                dashboardViewModel),

            new NavigationItem(
                "Work Orders",
                "📋",
                workOrderListViewModel),

            new NavigationItem(
                "Machines",
                "🏭",
                dashboardViewModel),

            new NavigationItem(
                "Inventory",
                "📦",
                dashboardViewModel),

            new NavigationItem(
                "Purchasing",
                "🛒",
                dashboardViewModel),

            new NavigationItem(
                "Reports",
                "📊",
                dashboardViewModel),

            new NavigationItem(
                "Settings",
                "⚙",
                dashboardViewModel)
        };

        _navigationService.CurrentViewChanged += NavigationService_CurrentViewChanged;

        _navigationService.NavigateTo(dashboardViewModel);

        CurrentViewModel = _navigationService.CurrentViewModel;

        _logger.LogInformation("MainViewModel created.");
    }

    public string ApplicationTitle
    {
        get => _applicationTitle;
        set => SetProperty(ref _applicationTitle, value);
    }

    public ViewModelBase? CurrentViewModel
    {
        get => _currentViewModel;
        set => SetProperty(ref _currentViewModel, value);
    }

    public IReadOnlyList<NavigationItem> NavigationItems { get; }

    [RelayCommand]
    private void Navigate(NavigationItem item)
    {
        _navigationService.NavigateTo(item.ViewModel);
    }

    private void NavigationService_CurrentViewChanged()
    {
        CurrentViewModel = _navigationService.CurrentViewModel;
    }
}