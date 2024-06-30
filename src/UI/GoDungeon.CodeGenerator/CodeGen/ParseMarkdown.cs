using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.CommandLineTools.CodeGen;

public partial class ParseMarkdown : IParseMarkdown
{
    /// <summary>
    /// The logger
    /// </summary>
    private readonly ILogger<ParseMarkdown> logger;

    /// <summary>
    /// The monster information
    /// </summary>
    public List<ICreature> CreatureList { get; set; } = new List<ICreature>();

    /// <summary>
    /// A list of monster Info
    /// </summary>
    public List<MonsterInfoViewModel> MonsterInfoList { get; set; } = new List<MonsterInfoViewModel>();
    public IServiceProvider Services { get; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="services">The DI service provider</param>
    /// <param name="loggerFactory">The logger factory</param>
    public ParseMarkdown(
        ILoggerFactory loggerFactory,
        IServiceProvider services)
    {
        logger = loggerFactory.CreateLogger<ParseMarkdown>();
        Services = services;
    }

    /// <summary>
    /// Parse any tables
    /// </summary>
    /// <param name="markDown">The markdown file</param>
    /// <returns>A markdown table</returns>
    public IMarkDownTableModel? ParseMarkDownTable(List<string> markDown)
    {
        var markDownTable = new MarkDownTableModel();
        int t = 0;
        do
        {
            if (!markDown.Any(m => m.Trim().StartsWith("|")))
            {
                return markDownTable;
            }

            // Get the table caption
            int tableCount = 0;
            var tableCaption = string.Empty;
            int pos = 0;
            do
            {
                if (markDown[t].Trim().StartsWith("#"))
                {
                    tableCaption = markDown[t].Replace("#", string.Empty).Trim();
                    pos = t;
                }
                if (markDown[t].Trim().StartsWith('|'))
                {
                    break;
                }
                t++;
            } while (t < markDown.Count);

            markDownTable.TableCaption?.Add(tableCaption);
            markDown[pos] = string.Empty;

            // Get the table
            List<string> table = new List<string>();
            do
            {
                if (markDown[t].Trim().StartsWith("|"))
                {
                    table.Add(markDown[t].Trim());
                    markDown[t] = string.Empty;
                    t++;
                }
                else
                {
                    break;
                }

            } while (t < markDown.Count);
            markDownTable.TableRows.Add(table);

        } while (t < markDown.Count);

        return markDownTable;
    }
}
