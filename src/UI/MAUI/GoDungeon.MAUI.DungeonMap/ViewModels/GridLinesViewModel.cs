using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.MAUI.DungeonMap.Enum;
using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.ViewModels;

public partial class GridLinesViewModel : DungeonBaseViewModel, IGridLines
{
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
            var staringPoint = new Point(0, i * ScaleFactor);
            var endingPoint = new Point(Height, i * ScaleFactor);
            canvas.DrawLine(staringPoint, endingPoint);
        }

        // Draw the vertical lines
        for (var i = 0; i <= VerticalLines; i++)
        {
            var staringPoint = new Point(i * ScaleFactor, 0);
            var endingPoint = new Point(i * ScaleFactor, Width);
            canvas.DrawLine(staringPoint, endingPoint);
        }
    }

    public override void Draw(ICanvas canvas, RectF dirtyRect)
    {
        ZIndex = (int) DungeonZIndexEnum.GridLines;
        DrawGridLines(canvas);
    }
}
