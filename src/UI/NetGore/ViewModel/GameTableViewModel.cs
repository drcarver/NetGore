using CommunityToolkit.Mvvm.ComponentModel;

using D20.Core.Interfaces;
using D20.Core.Models;

namespace NetGore.ViewModel;

public partial class GameTableViewModel : ObservableObject
{
    [ObservableProperty]
    string name;

    [ObservableProperty]
    string? description;

    public Guid Id { get; set; }

    public GameTableViewModel(GameTable table)
    {
        Id = table.Id;
        Name = table.ProperName ?? table.Name;
        Description = table.Description;
    }

    public GameTableViewModel()
    {
        Id = Guid.NewGuid();
    }
}
