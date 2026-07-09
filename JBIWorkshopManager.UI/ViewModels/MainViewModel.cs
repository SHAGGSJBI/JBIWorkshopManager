using JBI.WorkshopManager.UI.Navigation;
using JBI.WorkshopManager.UI.ViewModels.Base;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using System.Windows.Input;
using JBI.WorkshopManager.UI.Commands;

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
        NavigationItems = new ObservableCollection<NavigationItem>
{
    new("Dashboard", "🏠", dashboardViewModel)
};

        NavigateCommand = new RelayCommand(item =>
        {
            if (item is NavigationItem navigationItem)
            {
                _navigationService.NavigateTo(navigationItem.ViewModel);
            }
        });

        _logger.LogInformation("MainViewModel created.");
    }

    public ViewModelBase? CurrentViewModel =>
        _navigationService.CurrentViewModel;

    private void OnCurrentViewChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }

    public ObservableCollection<NavigationItem> NavigationItems { get; }

    public ICommand NavigateCommand { get; }
}