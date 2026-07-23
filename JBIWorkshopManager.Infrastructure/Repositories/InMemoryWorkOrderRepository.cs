using JBIWorkshopManager.Core.Interfaces;
using JBIWorkshopManager.Domain.Entities;

namespace JBIWorkshopManager.Infrastructure.Repositories;

public class InMemoryWorkOrderRepository : IWorkOrderRepository
{
    private readonly List<WorkOrder> _workOrders = new();

    public IEnumerable<WorkOrder> GetAll()
    {
        return _workOrders;
    }

    public WorkOrder? GetByNumber(string workOrderNumber)
    {
        return _workOrders.FirstOrDefault(x =>
            x.WorkOrderNumber.Equals(workOrderNumber,
                StringComparison.OrdinalIgnoreCase));
    }

    public void Add(WorkOrder workOrder)
    {
        _workOrders.Add(workOrder);
    }
}