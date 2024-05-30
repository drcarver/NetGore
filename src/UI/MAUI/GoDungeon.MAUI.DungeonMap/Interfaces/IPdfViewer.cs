namespace GoDungeon.MAUI.DungeonMap.Interfaces;

public interface IPdfViewer
{
    /// <summary>
    /// The pdf document to view (from a navigation parameter)
    /// </summary>
    public Stream? PdfDocumentStream { get; set; }
}