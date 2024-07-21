using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.Models;

public class ParseModel : IParseModel
{
    /// <summary>
    /// The route (the same as the directory in the system)
    /// </summary>
    public string? Route { get; }

    /// <summary>
    /// The tables in the markdown file
    /// </summary>
    public List<MarkDownTableModel> MarkDownTableModels { get; }

    /// <summary>
    /// The markdown file as a string
    /// </summary>
    public List<string> Markdown { get; }

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
    public ParseModel(string route, List<string> markdown)
    {
        Route = $"{route.Replace("\\", "/").Replace(".md", string.Empty).Substring(1)}";

        // Cleanup the route
        // Remove any _ or -
        var name = char.ToUpper(Route[0]) + Route.Substring(1);
        int hasUnderline = name.IndexOf("_");
        while (hasUnderline > 0)
        {
            hasUnderline = name.IndexOf("_");
            if (hasUnderline < 0)
            {
                hasUnderline = name.IndexOf("-");
            }
            if (hasUnderline >= 0)
            {
                var lastString = name.Substring(hasUnderline + 1);
                lastString = char.ToUpper(lastString[0]) + lastString.Substring(1);
                name = name.Substring(0, hasUnderline) + lastString;
            }
        }

        // Correct the case
        string newRoute = string.Empty;
        foreach (var dir in name.Split('/'))
        {
            try
            {
                newRoute = newRoute + "/" + char.ToUpper(dir[0]) + dir.Substring(1);
            }
            catch (Exception ex)
            {

            }
        }

        Route = "/" + newRoute.Replace("-", string.Empty);
        Markdown = markdown;
        MarkDownTableModels = [];
    }
}