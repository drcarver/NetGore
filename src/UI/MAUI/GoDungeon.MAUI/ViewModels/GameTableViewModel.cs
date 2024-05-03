using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Tables;

namespace GoDungeon.MAUI.ViewModels;

public partial class GameTableViewModel : ObservableObject
{
    [ObservableProperty]
    string name;

    [ObservableProperty]
    string? description;

    private Guid? Id { get; set; } = Guid.NewGuid();

    public GameTableViewModel(NamedTable table)
    {
        Id = table.Id;
        Name = table.ProperName ?? table.Name;
        Description = table.Description;
    }

    public GameTableViewModel()
    {
        Id = Guid.NewGuid();
        Name = string.Empty;
    }
}
