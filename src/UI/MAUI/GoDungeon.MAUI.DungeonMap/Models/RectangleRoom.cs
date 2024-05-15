namespace GoDungeon.MAUI.DungeonMap.Models;

using Microsoft.Maui.Controls.Shapes;

public class DungeonMap : IDrawable
{
    /// <summary>
    /// Return a rectangular room.  A square room is simple a rectangular room
    /// with the same height and width
    /// </summary>
    /// <param name="height">The eight of the room</param>
    /// <param name="width">The width of the room</param>
    /// <returns>THe requested rectangle</returns>
    private Rect RectangularRoom(double height, double width)
    {
        var rect = new Rect();
        rect.Height = height;
        rect.Width = height;
        return rect;
    }

    /// <summary>
    /// Request an ellipse as a circle
    /// </summary>
    /// <param name="radius">The radius of the circle</param>
    /// <returns>The requested ellipse</returns>
    private Ellipse CircularRoom(double radius)
    {
        var ellipse = new Ellipse();
        ellipse.WidthRequest = radius;
        return ellipse;
    }

    /// <summary>
    /// Draw a dungeon Map
    /// </summary>
    /// <param name="canvas"></param>
    /// <param name="dirtyRect"></param>
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.DrawRectangle(RectangularRoom(10, 10));
    }
}