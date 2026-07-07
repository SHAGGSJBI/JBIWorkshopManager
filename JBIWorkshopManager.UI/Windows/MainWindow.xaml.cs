using System.Windows;
using JBI.WorkshopManager.UI.ViewModels;

namespace JBI.WorkshopManager.UI.Windows;

public partial class MainWindow : Window
{
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();

        DataContext = viewModel;
    }
}