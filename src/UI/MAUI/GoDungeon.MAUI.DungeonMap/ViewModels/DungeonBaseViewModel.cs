using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.ViewModels;

public partial class DungeonBaseViewModel : BaseObjectViewModel, IDungeonBase
{
    protected int VerticalLines => (int)Height / ScaleFactor;
    protected int HorizontalLines => (int)Width / ScaleFactor;

    /// <summary>
    /// The size of 1 square on the dungeon map
    /// </summary>
    [ObservableProperty]
    private int scaleFactor = 20;

    [ObservableProperty]
    private string title = "Dungeon Map";

    [ObservableProperty]
    private double height = 600;

    [ObservableProperty]
    private double width = 800;

    [ObservableProperty]
    private int zIndex = (int) DungeonZIndexEnum.BaseMap;

    /// <summary>
    /// Draw the controls for map
    /// </summary>
    /// <param name="canvas">The canvas</param>
    /// <param name="dirtyRect">the dirty rectangle</param>
    public virtual void Draw(ICanvas canvas, RectF dirtyRect)
    {
    }
}
