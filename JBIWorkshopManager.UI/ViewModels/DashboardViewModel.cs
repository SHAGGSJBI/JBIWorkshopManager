using Microsoft.Extensions.Logging;
using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class DashboardViewModel : ViewModelBase
{
    private readonly ILogger<DashboardViewModel> _logger;

    public DashboardViewModel(ILogger<DashboardViewModel> logger)
    {
        _logger = logger;
        _logger.LogInformation("Dashboard loaded.");
    }
}