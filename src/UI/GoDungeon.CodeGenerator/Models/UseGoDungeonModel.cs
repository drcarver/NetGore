using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.Models;

public class UseGoDungeonModel
{
    /// <summary>
    /// The output directory for the file
    /// </summary>
    public string? OutputDirectory { get; internal set; }

    /// <summary>
    /// The name space for the file
    /// </summary>
    public string? NameSpace { get; internal set; }

    /// <summary>
    /// The file name
    /// </summary>
    public string? FileName { get; internal set; }

    /// <summary>
    /// The model info for the file
    /// </summary>
    public List<string> DIObjects { get; internal set; }
}
