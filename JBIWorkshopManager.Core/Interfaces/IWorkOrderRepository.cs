using JBIWorkshopManager.Domain.Entities;

namespace JBIWorkshopManager.Core.Interfaces;

public interface IWorkOrderRepository
{
    IEnumerable<WorkOrder> GetAll();

    WorkOrder? GetByNumber(string workOrderNumber);

    void Add(WorkOrder workOrder);
}