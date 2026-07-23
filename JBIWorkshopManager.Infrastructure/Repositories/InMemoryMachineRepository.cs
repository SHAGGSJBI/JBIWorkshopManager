using JBIWorkshopManager.Core.Interfaces;
using JBIWorkshopManager.Domain.Entities;
using JBIWorkshopManager.Domain.Enums;

namespace JBIWorkshopManager.Infrastructure.Repositories;

public sealed class InMemoryMachineRepository : IMachineRepository
{
    private readonly List<Machine> _machines =
[
    new Machine(
        "0021UA",
        "Arena Rake",
        MachineCategory.ArenaRake,
        6.5m),

    new Machine(
        "0034SL",
        "6' Slasher",
        MachineCategory.Slasher,
        5.0m),

    new Machine(
        "0051PD",
        "Post Driver",
        MachineCategory.PostDriver,
        8.0m)
];

    public Task<IReadOnlyList<Machine>> GetAllAsync()
    {
        return Task.FromResult((IReadOnlyList<Machine>)_machines);
    }

    public Task<Machine?> GetByIdAsync(Guid id)
    {
        return Task.FromResult(_machines.FirstOrDefault(x => x.Id == id));
    }

    public Task<Machine?> GetByItemCodeAsync(string itemCode)
    {
        return Task.FromResult(
            _machines.FirstOrDefault(x =>
                x.ItemCode.Equals(itemCode, StringComparison.OrdinalIgnoreCase)));
    }

    public Task<Machine?> GetByMachineNameAsync(string machineName)
    {
        return Task.FromResult(
            _machines.FirstOrDefault(x =>
                x.MachineName.Equals(machineName,
                    StringComparison.OrdinalIgnoreCase)));
    }

    public Task AddAsync(Machine machine)
    {
        _machines.Add(machine);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Machine machine)
    {
        // No action required for an in-memory list.
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id)
    {
        var machine = _machines.FirstOrDefault(x => x.Id == id);

        if (machine != null)
        {
            _machines.Remove(machine);
        }

        return Task.CompletedTask;
    }
}