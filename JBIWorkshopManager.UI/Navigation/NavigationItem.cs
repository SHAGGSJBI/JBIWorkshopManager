using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.Navigation;

public sealed class NavigationItem
{
    public NavigationItem(
        string title,
        string icon,
        ViewModelBase viewModel)
    {
        Title = title;
        Icon = icon;
        ViewModel = viewModel;
    }

    public string Title { get; }

    public string Icon { get; }

    public ViewModelBase ViewModel { get; }
}