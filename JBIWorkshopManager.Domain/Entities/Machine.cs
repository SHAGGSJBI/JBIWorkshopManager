using JBIWorkshopManager.Domain.Enums;

namespace JBIWorkshopManager.Domain.Entities;

public sealed class Machine
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string ItemCode { get; private set; } = string.Empty;

    public string MachineName { get; private set; } = string.Empty;

    public MachineCategory Category { get; private set; }

    public string? Description { get; private set; }

    public string? DrawingNumber { get; private set; }

    public string? DrawingRevision { get; private set; }

    public decimal StandardBuildHours { get; private set; }

    public bool IsActive { get; private set; } = true;

    private Machine()
    {
        // Required by EF Core
    }

    public Machine(
        string itemCode,
        string machineName,
        MachineCategory category,
        decimal standardBuildHours)
    {
        ItemCode = itemCode;
        MachineName = machineName;
        Category = category;
        StandardBuildHours = standardBuildHours;
    }

    public void UpdateDrawing(
        string drawingNumber,
        string revision)
    {
        DrawingNumber = drawingNumber;
        DrawingRevision = revision;
    }

    public void Deactivate()
    {
        IsActive = false;
    }
}