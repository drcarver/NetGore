using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.ViewModels;

public partial class DungeonMapViewModel : ObservableObject, IDrawable, IDungeonMapViewModel
{
    private int scaleFactor = 20;
    private int VerticalLines => (int)Height / scaleFactor;
    private int HorizontalLines => (int)Width / scaleFactor;

    [ObservableProperty]
    private string title= "Dungeon Map";

    [ObservableProperty]
    private double height = 600;

    [ObservableProperty]
    private double width = 800;

    private void DrawStartingArea(ICanvas canvas)
    {
        int centerPoint = (int) (Width / 2);
        var leftWallStart = centerPoint - ((int)(20 / 2) * scaleFactor);
        var rightWallStart = centerPoint + ((int)(20 / 2) * scaleFactor);
        var top = 20 * scaleFactor;

        canvas.StrokeColor = Colors.Black;
        canvas.StrokeSize = 2;
        canvas.DrawRectangle(leftWallStart, 0, 20, 20);
    }

    /// <summary>
    /// Draw the grid lines on the canvas
    /// </summary>
    /// <param name="canvas"></param>
    private void DrawGridLines(ICanvas canvas)
    {
        canvas.FillColor = Colors.Gray;
        canvas.StrokeColor = Colors.LightGray;
        canvas.StrokeSize = 1;

        // Draw the horizontal lines
        for (var i = 0; i < HorizontalLines; i++)
        {
            var staringPoint = new Point(0, i * scaleFactor);
            var endingPoint = new Point(Height, i * scaleFactor);
            canvas.DrawLine(staringPoint, endingPoint);
            canvas.DrawString($"{i/2}", (float) 0, (float) (i+2) * scaleFactor, HorizontalAlignment.Center);
        }

        // Draw the vertical lines
        for (var i = 0; i <= VerticalLines; i++)
        {
            var staringPoint = new Point(i * scaleFactor, 0);
            var endingPoint = new Point(i * scaleFactor, Width);
            canvas.DrawLine(staringPoint, endingPoint);
        }
    }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        Title = "Random Dungeon Map";
        DrawGridLines(canvas);
        DrawStartingArea(canvas);
    }
}
