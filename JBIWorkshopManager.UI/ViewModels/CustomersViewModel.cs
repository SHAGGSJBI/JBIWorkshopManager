using Microsoft.Extensions.Logging;
using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class CustomersViewModel : ViewModelBase
{
    public CustomersViewModel(ILogger<CustomersViewModel> logger)
    {
        logger.LogInformation("Customers module loaded.");
    }
}