namespace GoDungeon.MAUI.DungeonMap.Interfaces;

public interface IDungeonMapViewModel
{
    void Draw(ICanvas canvas, RectF dirtyRect);
}