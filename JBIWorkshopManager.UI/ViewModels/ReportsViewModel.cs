using Microsoft.Extensions.Logging;
using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class ReportsViewModel : ViewModelBase
{
    public ReportsViewModel(ILogger<ReportsViewModel> logger)
    {
        logger.LogInformation("Reports module loaded.");
    }
}