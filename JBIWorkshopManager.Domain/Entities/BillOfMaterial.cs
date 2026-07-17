namespace JBIWorkshopManager.Domain.Entities;

public sealed class BillOfMaterial
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public Guid MachineId { get; private set; }

    public Machine Machine { get; private set; } = null!;

    private readonly List<BillOfMaterialItem> _items = new();

    public IReadOnlyCollection<BillOfMaterialItem> Items => _items.AsReadOnly();

    private BillOfMaterial()
    {
        // Required by EF Core
    }

    public BillOfMaterial(Guid machineId)
    {
        MachineId = machineId;
    }

    public void AddItem(Part part, decimal quantity)
    {
        _items.Add(new BillOfMaterialItem(part, quantity));
    }
}