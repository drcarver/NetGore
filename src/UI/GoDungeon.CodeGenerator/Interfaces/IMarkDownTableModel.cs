namespace GoDungeon.CodeGenerator.Interfaces;

public interface IMarkDownTableModel
{
    /// <summary>
    /// The table header
    /// </summary>
    List<string> TableHeader { get; }

    /// <summary>
    /// The table rows
    /// </summary>
    List<string> TableRows { get; }
}
