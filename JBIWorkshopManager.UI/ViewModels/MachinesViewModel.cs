using Microsoft.Extensions.Logging;
using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class MachinesViewModel : ViewModelBase
{
    public MachinesViewModel(ILogger<MachinesViewModel> logger)
    {
        logger.LogInformation("Machines module loaded.");
    }
}