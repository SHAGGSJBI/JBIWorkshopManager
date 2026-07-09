using System.Collections.ObjectModel;

namespace JBI.WorkshopManager.UI.Navigation;

public sealed class NavigationRegistry
{
    public ObservableCollection<NavigationItem> Items { get; } = new();
}