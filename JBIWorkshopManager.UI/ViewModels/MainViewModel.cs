using JBI.WorkshopManager.UI.Navigation;
using JBI.WorkshopManager.UI.ViewModels.Base;
using Microsoft.Extensions.Logging;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class MainViewModel : ViewModelBase
{
    private readonly ILogger<MainViewModel> _logger;
    private readonly INavigationService _navigationService;

    public MainViewModel(
        ILogger<MainViewModel> logger,
        INavigationService navigationService,
        DashboardViewModel dashboardViewModel)
    {
        _logger = logger;
        _navigationService = navigationService;

        _navigationService.CurrentViewChanged += OnCurrentViewChanged;

        _navigationService.NavigateTo(dashboardViewModel);

        _logger.LogInformation("MainViewModel created.");
    }

    public ViewModelBase? CurrentViewModel =>
        _navigationService.CurrentViewModel;

    private void OnCurrentViewChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}