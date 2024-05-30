using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoDungeon.MAUI.DungeonMap.ViewModels;

public class DungeonRoomsViewModel : DungeonBaseViewModel
{
    private void DrawStartingArea(ICanvas canvas)
    {
        int centerPoint = (int)(Width / 2);
        var leftWallStart = centerPoint - ((int)(20 / 2) * ScaleFactor);
        var rightWallStart = centerPoint + ((int)(20 / 2) * ScaleFactor);
        var top = 20 * ScaleFactor;

        canvas.StrokeColor = Colors.Black;
        canvas.StrokeSize = 2;
        canvas.DrawRectangle(leftWallStart, 0, 20, 20);
    }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        DrawStartingArea(canvas);
    }
}
