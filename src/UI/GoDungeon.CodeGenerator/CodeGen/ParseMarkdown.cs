using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.CodeGenerator.ViewModels;

namespace GoDungeon.CommandLineTools.CodeGen;

public partial class ParseMarkdown : IParseMarkdown
{
    /// <summary>
    /// The logger
    /// </summary>
    private readonly ILogger<ParseMarkdown> logger;

    /// <summary>
    /// The parse models for the website
    /// </summary>
    public List<ParseModel> ParseModels { get; } = [];

    /// <summary>
    /// The rules files (text only)
    /// </summary>
    public List<RulesViewModel> RulesModels { get; } = [];

    /// <summary>
    /// The magic item files
    /// </summary>
    public List<MagicItemViewModel> MagicItemsModels { get; } = [];

    /// <summary>
    /// The list of monsters
    /// </summary>
    public List<MonsterViewModel> MonsterModels { get; } = [];

    /// <summary>
    /// The list of spells
    /// </summary>
    public List<SpellViewModel> SpellModels { get; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    public ParseMarkdown(ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<ParseMarkdown>();
    }

    /// <summary>
    /// Parse the markdown to .html
    /// </summary>
    /// <param name="parseModel">The parse model for the markdown</param>
    /// <returns></returns>
    public List<string> ParseMarkdownToHTML(ParseModel parseModel)
    {
        List<string> html = [];
        foreach (var line in parseModel.Markdown)
        {
        }
        return html;
    }

    /// <summary>
    /// Parse any tables
    /// </summary>
    /// <param name="parseModel">The parse model for the file</param>
    public void ParseMarkDownTable(ParseModel parseModel)
    {
        // Are there any tables in the file
        if (!parseModel.Markdown.Any(m => m.TrimStart().StartsWith("|")))
        {
            return;
        }

        var markDownTableModel = new MarkDownTableModel();
        int t = 0;
        int tableCount = 0;
        do
        {
            // Get the caption for the table
            var tableCaption = string.Empty;
            do
            {
                if (parseModel.Markdown[t].StartsWith("#"))
                {
                    tableCaption = parseModel.Markdown[t].Replace("#", string.Empty).Trim();
                }
                if (parseModel.Markdown[t].StartsWith('|'))
                {
                    break;
                }
                t++;
            } while (t < parseModel.Markdown.Length);

            // Are we at the end of the file
            if (t == parseModel.Markdown.Length)
            {
                break;
            }

            // Parse the next table in the file
            parseModel.MarkDownTableModels.Add(new MarkDownTableModel());
            parseModel.MarkDownTableModels[parseModel.MarkDownTableModels.Count() - 1].TableCaption?.Add(tableCaption);
            parseModel.MarkDownTableModels[parseModel.MarkDownTableModels.Count() - 1].MarkdownLine = t;
            while (t < parseModel.Markdown.Length && parseModel.Markdown[t].StartsWith("|"))
            {
                parseModel.MarkDownTableModels[parseModel.MarkDownTableModels.Count() - 1].TableRows.Add(parseModel.Markdown[t]);
                t++;
            }
        } while (t < parseModel.Markdown.Length);
    }
}
