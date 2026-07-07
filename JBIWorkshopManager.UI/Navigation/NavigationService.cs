using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.Navigation;

public class NavigationService : INavigationService
{
    public ViewModelBase? CurrentViewModel { get; private set; }

    public event Action? CurrentViewChanged;

    public void NavigateTo(ViewModelBase viewModel)
    {
        CurrentViewModel = viewModel;
        CurrentViewChanged?.Invoke();
    }
}