using JBI.WorkshopManager.UI.ViewModels.Base;
using JBIWorkshopManager.Core.Interfaces;
using JBIWorkshopManager.Domain.Entities;
using System.Collections.ObjectModel;

namespace JBI.WorkshopManager.UI.ViewModels.WorkOrders;

public class WorkOrderListViewModel : ViewModelBase
{
    private readonly IWorkOrderRepository _workOrderRepository;

    public ObservableCollection<WorkOrder> WorkOrders { get; } = new();

    public WorkOrderListViewModel(IWorkOrderRepository workOrderRepository)
    {
        _workOrderRepository = workOrderRepository;

        LoadWorkOrders();
    }

    private void LoadWorkOrders()
    {
        WorkOrders.Clear();

        foreach (var workOrder in _workOrderRepository.GetAll())
        {
            WorkOrders.Add(workOrder);
        }
    }
}