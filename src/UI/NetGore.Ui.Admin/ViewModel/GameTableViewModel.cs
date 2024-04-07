using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Core.Interfaces;

namespace NetGore.UI.Admin.ViewModel;

public partial class GameTableGridViewModel : ObservableObject
{
    [ObservableProperty]
    string name;

    [ObservableProperty]
    string dice;

    public Guid Id { get; set; }

    public GameTableGridViewModel(IGameTable table)
    {
        Id = table.Id;
        Name = table.ProperName ?? table.Name;
        Dice = $"d{table.DiceSides}";
    }
}
