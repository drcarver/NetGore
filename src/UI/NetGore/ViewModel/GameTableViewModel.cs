using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Core.Interfaces;

namespace NetGore.ViewModel;

public partial class GameTableViewModel : ObservableObject
{
    [ObservableProperty]
    string name;

    [ObservableProperty]
    string dice;

    public Guid Id { get; set; }

    public GameTableViewModel(IGameTable table)
    {
        Id = table.Id;
        Name = table.ProperName ?? table.Name;
        Dice = $"d{table.DiceSides}";
    }
}
