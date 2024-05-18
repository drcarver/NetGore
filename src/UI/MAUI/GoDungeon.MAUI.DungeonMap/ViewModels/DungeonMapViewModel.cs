using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Storage;
using System.Text;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Interfaces;
using GoDungeon.RandomDungeon;
using GoDungeon.RandomDungeon.Interfaces;
using System.IO;
using System.Threading;

namespace GoDungeon.MAUI.DungeonMap.ViewModels;

public partial class DungeonMapViewModel : BaseObjectViewModel, IDungeonMap
{
    /// <summary>
    /// The DI container
    /// </summary>
    protected IServiceProvider Services { get; }

    /// <summary>
    /// The dungeon model
    /// </summary>
    public IRandomDungeonModel Model { get; }

    [ObservableProperty]
    private int width = 800;

    [ObservableProperty]
    private int height = 600;

    [ObservableProperty]
    private string? title = "Random Dungeon";

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
    private string rowDefinitions = "600,Auto,Auto,Auto";

    [RelayCommand]
    private async Task ExportToPDf()
    {
        using (var ms = new MemoryStream())
        {
            Model.ExportToPDF(ms);
            var fileSaverResult = await FileSaver.Default.SaveAsync("RandomDungeon.pdf", ms);
            if (fileSaverResult.IsSuccessful)
            {
                await Toast.Make($"The file was saved successfully to location: {fileSaverResult.FilePath}").Show();
            }
            else
            {
                await Toast.Make($"The file was not saved successfully with error: {fileSaverResult.Exception.Message}").Show();
            }
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="services">THe services collection</param>
    public DungeonMapViewModel(IServiceProvider services,
        IRandomDungeonModel model)
    {
        Services = services;
        Model = model;
    }
}
