using System.Collections.Immutable;

using GoDungeon.CodeGenerator.Models;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IParseModel
{
    /// <summary>
    /// The file path for the markdown file
    /// </summary>
    string? Route { get; }

    /// <summary>
    /// The tables in the markdown file
    /// </summary>
    List<MarkDownTableModel> MarkDownTableModels { get; }

    /// <summary>
    /// The markdown file as a string
    /// </summary>
    ImmutableArray<string> Markdown { get; }

    /// <summary>
    /// The markdown file as .html
    /// </summary>
    List<string> MarkDownHtml { get; set; }

    /// <summary>
    /// The headers in the .html file
    /// </summary>
    List<HeaderModel> Headers { get; set; }
}
