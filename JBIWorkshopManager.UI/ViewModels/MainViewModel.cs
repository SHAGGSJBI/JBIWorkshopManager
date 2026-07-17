using Microsoft.Extensions.Logging;
using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class MainViewModel : ViewModelBase
{
    private readonly ILogger<MainViewModel> _logger;

    private string _applicationTitle = "JBI Workshop Manager";

    public MainViewModel(ILogger<MainViewModel> logger)
    {
        _logger = logger;

        _logger.LogInformation("MainViewModel created.");
    }

    public string ApplicationTitle
    {
        get => _applicationTitle;
        set => SetProperty(ref _applicationTitle, value);
    }
}