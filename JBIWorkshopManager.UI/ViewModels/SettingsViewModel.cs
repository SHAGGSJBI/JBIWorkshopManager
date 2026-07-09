using Microsoft.Extensions.Logging;
using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.ViewModels;

public sealed class SettingsViewModel : ViewModelBase
{
    public SettingsViewModel(ILogger<SettingsViewModel> logger)
    {
        logger.LogInformation("Settings module loaded.");
    }
}