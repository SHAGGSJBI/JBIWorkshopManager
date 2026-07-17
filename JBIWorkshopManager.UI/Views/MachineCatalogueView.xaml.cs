using JBI.WorkshopManager.UI.ViewModels;

namespace JBI.WorkshopManager.UI.Views;

public partial class MachineCatalogueView
{
    public MachineCatalogueView(MachineCatalogueViewModel viewModel)
    {
        InitializeComponent();

        DataContext = viewModel;

        Loaded += async (_, _) => await viewModel.LoadAsync();
    }
}