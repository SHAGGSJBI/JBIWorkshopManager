namespace JBIWorkshopManager.Domain.Entities;

public sealed class Part
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string PartNumber { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public bool IsManufactured { get; private set; }

    public bool IsPurchased => !IsManufactured;

    public decimal QuantityOnHand { get; private set; }

    public decimal MinimumStockLevel { get; private set; }

    public bool IsActive { get; private set; } = true;

    private Part()
    {
        // Required by EF Core
    }

    public Part(
        string partNumber,
        string description,
        bool isManufactured)
    {
        PartNumber = partNumber;
        Description = description;
        IsManufactured = isManufactured;
    }

    public void AdjustStock(decimal quantity)
    {
        QuantityOnHand += quantity;
    }

    public void Deactivate()
    {
        IsActive = false;
    }
}