using System.Windows.Controls;
using JBI.WorkshopManager.UI.ViewModels.WorkOrders;

namespace JBI.WorkshopManager.UI.Views.WorkOrders;

public partial class NewWorkOrderView : UserControl
{
    public NewWorkOrderView(NewWorkOrderViewModel viewModel)
    {
        InitializeComponent();

        DataContext = viewModel;
    }
}