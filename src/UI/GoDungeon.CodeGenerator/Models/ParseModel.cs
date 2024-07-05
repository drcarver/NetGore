using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace GoDungeon.CodeGenerator.Models;

public class ParseModel
{
    /// <summary>
    /// The file path for the markdown file
    /// </summary>
    public string? Route { get; }

    /// <summary>
    /// The file headers
    /// </summary>
    public List<string> FileHeaders { get; } = [];

    /// <summary>
    /// The tables in the markdown file
    /// </summary>
    public List<MarkDownTableModel> MarkDownTableModels { get; }

    /// <summary>
    /// The markdown file as a string
    /// </summary>
    public ImmutableArray<string> Markdown { get; }

    /// <summary>
    /// The markdown file as .html
    /// </summary>
    public List<string> MarkDownHtml { get; set; } = [];

    /// <summary>
    /// Set the readonly properties
    /// </summary>
    /// <param name="route">The route to the markdown</param>
    /// <param name="markdown">The markdown data</param>
    public ParseModel(string route, ImmutableArray<string> markdown)
    {
        Route = route;
        Markdown = markdown;
        MarkDownTableModels = [];

        foreach (var line in Markdown)
        {
            if (line.Contains(":"))
            {
                FileHeaders.Add(line);
            }
            else
            {
                break;
            }
        }
    }
}