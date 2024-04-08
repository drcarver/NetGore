using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Core.Interfaces;

namespace NetGore.ViewModel;

public partial class GameTableViewModel : ObservableObject
{
    [ObservableProperty]
    string name;

    [ObservableProperty]
    string? description;

    public Guid Id { get; set; }

    public GameTableViewModel(IGameTable table)
    {
        Id = table.Id;
        Name = table.ProperName ?? table.Name;
        Description = table.Description;
    }
}
