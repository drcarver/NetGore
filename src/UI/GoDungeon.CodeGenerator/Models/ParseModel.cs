using System.Collections.Immutable;

using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.Models;

public class ParseModel : IParseModel
{
    /// <summary>
    /// The route (the same as the directory in the system)
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
    /// The headers in the .html file
    /// </summary>
    public List<HeaderModel> Headers { get; set; } = [];

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