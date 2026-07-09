using Microsoft.Extensions.Logging;
using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class PurchasingViewModel : ViewModelBase
{
    public PurchasingViewModel(ILogger<PurchasingViewModel> logger)
    {
        logger.LogInformation("Purchasing module loaded.");
    }
}