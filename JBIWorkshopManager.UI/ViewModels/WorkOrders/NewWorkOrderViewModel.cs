using System.Windows;
using CommunityToolkit.Mvvm.Input;
using JBI.WorkshopManager.UI.ViewModels.Base;
using JBIWorkshopManager.Core.Interfaces;
using JBIWorkshopManager.Domain.Entities;
using System.Collections.ObjectModel;

namespace JBI.WorkshopManager.UI.ViewModels.WorkOrders;

public partial class NewWorkOrderViewModel : ViewModelBase
{
    private readonly IMachineRepository _machineRepository;
    private readonly IWorkOrderRepository _workOrderRepository;

    public ObservableCollection<Machine> Machines { get; } = new();

    private Machine? _selectedMachine;

    public Machine? SelectedMachine
    {
        get => _selectedMachine;
        set
        {
            if (SetProperty(ref _selectedMachine, value))
            {
                if (value is null)
                    return;

                MachineName = value.MachineName;
                ItemCode = value.ItemCode;
            }
        }
    }

    public NewWorkOrderViewModel(
        IMachineRepository machineRepository,
        IWorkOrderRepository workOrderRepository)
    {
        _machineRepository = machineRepository;
        _workOrderRepository = workOrderRepository;

        _ = LoadMachinesAsync();
    }

    private string _workOrderNumber = string.Empty;
    public string WorkOrderNumber
    {
        get => _workOrderNumber;
        set => SetProperty(ref _workOrderNumber, value);
    }

    private string _itemCode = string.Empty;
    public string ItemCode
    {
        get => _itemCode;
        set => SetProperty(ref _itemCode, value);
    }

    private string _machineName = string.Empty;
    public string MachineName
    {
        get => _machineName;
        set => SetProperty(ref _machineName, value);
    }

    private int _quantity = 1;
    public int Quantity
    {
        get => _quantity;
        set => SetProperty(ref _quantity, value);
    }

    private DateTime _orderDate = DateTime.Today;
    public DateTime OrderDate
    {
        get => _orderDate;
        set => SetProperty(ref _orderDate, value);
    }

    private DateTime _dueDate = DateTime.Today.AddDays(7);
    public DateTime DueDate
    {
        get => _dueDate;
        set => SetProperty(ref _dueDate, value);
    }

    private async Task LoadMachinesAsync()
    {
        var machines = await _machineRepository.GetAllAsync();

        Machines.Clear();

        foreach (var machine in machines)
        {
            Machines.Add(machine);
        }
    }

    
    [RelayCommand]
    private async Task CreateWorkOrder()
    {
        var machines = await _machineRepository.GetAllAsync();

        var machine = machines.FirstOrDefault(m => m.MachineName == MachineName);

        if (machine is null)
        {
            MessageBox.Show(
                "Please enter a valid machine.",
                "Machine Not Found",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);

            return;
        }

        var workOrder = new WorkOrder(
            WorkOrderNumber,
            machine,
            Quantity,
            OrderDate,
            DueDate);

        _workOrderRepository.Add(workOrder);

        MessageBox.Show(
            $"Work Order {WorkOrderNumber} created successfully!",
            "Success",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
    }
}