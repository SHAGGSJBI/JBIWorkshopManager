using JBI.WorkshopManager.UI.ViewModels.Base;

namespace JBI.WorkshopManager.UI.Navigation;

public interface INavigationService
{
    ViewModelBase? CurrentViewModel { get; }

    void NavigateTo(ViewModelBase viewModel);

    event Action? CurrentViewChanged;
}