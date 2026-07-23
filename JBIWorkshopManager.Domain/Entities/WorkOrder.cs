using JBIWorkshopManager.Domain.Enums;

namespace JBIWorkshopManager.Domain.Entities;

public class WorkOrder
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string WorkOrderNumber { get; private set; } = string.Empty;

    public DateTime OrderDate { get; private set; }

    public DateTime DueDate { get; private set; }

    public Machine Machine { get; private set; }

    public int QuantityOrdered { get; private set; }

    public int QuantityCompleted { get; private set; }

    public WorkOrderStatus Status { get; private set; }

    public PauseReason PauseReason { get; private set; } = PauseReason.None;

    // Factory Workflow
    public bool NeilPartsComplete { get; private set; }

    public bool CncPartsComplete { get; private set; }

    public bool SupervisorSignedOff { get; private set; }

    public string Notes { get; private set; } = string.Empty;

    // Timing
    public DateTime? StartedAt { get; private set; }

    public DateTime? FinishedAt { get; private set; }

    public WorkOrder(
        string workOrderNumber,
        Machine machine,
        int quantityOrdered,
        DateTime orderDate,
        DateTime dueDate)
    {
        WorkOrderNumber = workOrderNumber;
        Machine = machine;
        QuantityOrdered = quantityOrdered;
        OrderDate = orderDate;
        DueDate = dueDate;

        Status = WorkOrderStatus.NotStarted;
    }

    public void Start()
    {
        if (Status != WorkOrderStatus.NotStarted)
            return;

        Status = WorkOrderStatus.InProgress;
        StartedAt = DateTime.Now;
    }

    public void Pause(PauseReason reason)
    {
        if (Status != WorkOrderStatus.InProgress)
            return;

        Status = WorkOrderStatus.Paused;
        PauseReason = reason;
    }

    public void Resume()
    {
        if (Status != WorkOrderStatus.Paused)
            return;

        Status = WorkOrderStatus.InProgress;
        PauseReason = PauseReason.None;
    }

    public void CompleteUnits(int quantity)
    {
        if (quantity <= 0)
            return;

        QuantityCompleted += quantity;

        if (QuantityCompleted >= QuantityOrdered)
        {
            QuantityCompleted = QuantityOrdered;
            Status = WorkOrderStatus.Completed;
            FinishedAt = DateTime.Now;
        }
    }

    public void MarkNeilPartsComplete()
    {
        NeilPartsComplete = true;
    }

    public void MarkCncPartsComplete()
    {
        CncPartsComplete = true;
    }

    public void SignOff()
    {
        SupervisorSignedOff = true;
    }

    public void UpdateNotes(string notes)
    {
        Notes = notes;
    }
}