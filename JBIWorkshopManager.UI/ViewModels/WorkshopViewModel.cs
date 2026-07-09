using Microsoft.Extensions.Logging;
using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class WorkshopViewModel : ViewModelBase
{
    public WorkshopViewModel(ILogger<WorkshopViewModel> logger)
    {
        logger.LogInformation("Workshop module loaded.");
    }
}