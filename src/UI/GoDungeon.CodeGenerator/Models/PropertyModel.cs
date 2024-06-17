namespace GoDungeon.CodeGenerator.Models;

public class PropertyModel
{
    /// <summary>
    /// The file the table is in
    /// </summary>
    public string FilePath { get; set; }

    /// <summary>
    /// The name of the property
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The property type
    /// </summary>
    public string? Value { get; set; }
}
