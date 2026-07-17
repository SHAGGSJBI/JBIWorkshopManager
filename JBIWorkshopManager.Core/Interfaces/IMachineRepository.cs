using JBIWorkshopManager.Domain.Entities;

namespace JBIWorkshopManager.Core.Interfaces;

public interface IMachineRepository
{
    Task<IReadOnlyList<Machine>> GetAllAsync();

    Task<Machine?> GetByIdAsync(Guid id);

    Task<Machine?> GetByItemCodeAsync(string itemCode);

    Task AddAsync(Machine machine);

    Task UpdateAsync(Machine machine);

    Task DeleteAsync(Guid id);
}