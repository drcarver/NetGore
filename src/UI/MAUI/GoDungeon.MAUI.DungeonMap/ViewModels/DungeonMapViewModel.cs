using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.ViewModels;

public partial class DungeonMapViewModel : ObservableObject, IDrawable, IDungeonMapViewModel
{
    [ObservableProperty]
    private string title;

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        Title = "Random Dungeon Map";
    }
}
