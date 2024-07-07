namespace GoDungeon.CodeGenerator.Models;

public class HeaderModel
{
    /// <summary>
    /// The content as a c# string
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The header level
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The line number in the file
    /// </summary>
    public int LineNumber { get; set; }

    /// <summary>
    /// The header content
    /// </summary>
    public string Content { get; set; }
}
