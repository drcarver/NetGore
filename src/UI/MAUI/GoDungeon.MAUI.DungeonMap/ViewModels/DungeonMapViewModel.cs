using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Interfaces;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.ViewModels;

public partial class DungeonMapViewModel : BaseObjectViewModel, IDungeonMap
{
    /// <summary>
    /// The DI container
    /// </summary>
    protected IServiceProvider Services { get; }

    [ObservableProperty]
    private string? dungeonPurpose;

    [ObservableProperty]
    private string? dungeonHistory;

    [ObservableProperty]
    private DungeonRoomsViewModel? dungeonRoomsViewModel;

    [ObservableProperty]
    private GridLinesViewModel? gridLinesViewModel;

    [ObservableProperty]
    private string columnDefinitions = "700,100";

    [ObservableProperty]
    private string rowDefinitions = "600,AUto,Auto";

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="services">THe services collection</param>
    public DungeonMapViewModel(IServiceProvider services)
    {
        Services = services;
    }
}
