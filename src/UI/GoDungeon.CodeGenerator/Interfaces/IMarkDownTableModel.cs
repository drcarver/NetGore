namespace GoDungeon.CodeGenerator.Interfaces;

public interface IMarkDownTableModel
{
    /// <summary>
    /// The line in the markdown file where the table starts
    /// </summary>
    int MarkdownLine { get; set; }

    /// <summary>
    /// The table caption
    /// </summary>
    List<string>? TableCaption { get; set; }

    /// <summary>
    /// The table rows
    /// </summary>
    List<string> TableRows { get; }
}
