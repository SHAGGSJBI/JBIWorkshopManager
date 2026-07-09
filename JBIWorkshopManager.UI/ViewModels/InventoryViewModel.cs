using Microsoft.Extensions.Logging;
using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class InventoryViewModel : ViewModelBase
{
    public InventoryViewModel(ILogger<InventoryViewModel> logger)
    {
        logger.LogInformation("Inventory module loaded.");
    }
}