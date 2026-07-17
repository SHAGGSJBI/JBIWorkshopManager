using CommunityToolkit.Mvvm.ComponentModel;
using JBIWorkshopManager.Core.Interfaces;
using JBIWorkshopManager.Domain.Entities;
using System.Collections.ObjectModel;

namespace JBI.WorkshopManager.UI.ViewModels;

public partial class MachineCatalogueViewModel : ObservableObject
{
    private readonly IMachineRepository _repository;

    public ObservableCollection<Machine> Machines { get; } = new();

    public MachineCatalogueViewModel(IMachineRepository repository)
    {
        _repository = repository;
    }

    public async Task LoadAsync()
    {
        Machines.Clear();

        var machines = await _repository.GetAllAsync();

        foreach (var machine in machines)
        {
            Machines.Add(machine);
        }
    }
}