namespace GoDungeon.CodeGenerator.Interfaces;

public interface IMarkDownTableModel
{
    /// <summary>
    /// The table caption
    /// </summary>
    List<string>? TableCaption { get; set; }

    /// <summary>
    /// The table rows
    /// </summary>
    List<List<string>> TableRows { get; }

    /// <summary>
    /// The markdown file that contains the table
    /// </summary>
    string FilePath { get; set; }

}
