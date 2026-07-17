namespace JBIWorkshopManager.Domain.Entities;

public sealed class BillOfMaterialItem
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public Part Part { get; private set; }

    public decimal Quantity { get; private set; }

    private BillOfMaterialItem()
    {
        Part = null!;
    }

    public BillOfMaterialItem(Part part, decimal quantity)
    {
        Part = part;
        Quantity = quantity;
    }
}