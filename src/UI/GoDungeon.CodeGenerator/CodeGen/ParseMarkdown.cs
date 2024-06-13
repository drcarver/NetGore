using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.CommandLineTools.CodeGen;

public partial class ParseMarkdown : IParseMarkdown
{
    /// <summary>
    /// The monster information
    /// </summary>
    public List<ICreature> CreatureList { get; set; } = new List<ICreature>();

    /// <summary>
    /// A list of monster Info
    /// </summary>
    public List<MonsterInfoViewModel> MonsterInfoList { get; set; } = new List<MonsterInfoViewModel>();

    /// <summary>
    /// The list of services
    /// </summary>
    private IServiceProvider ServiceProvider { get; }

    /// <summary>
    /// THe list of monsters
    /// </summary>
    public IMonsterLists MonsterLists { get; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="monsterLists">The monster lists</param>
    public ParseMarkdown(
        IMonsterLists monsterLists,
        IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
        MonsterLists = monsterLists;
    }

    /// <summary>
    /// Parse any tables
    /// </summary>
    /// <param name="markDown">The markdown file</param>
    /// <returns>A markdown table</returns>
    public IMarkDownTableModel? ParseMarkDownTable(List<string> markDown)
    {
        IMarkDownTableModel markDownTable = null;
        foreach (var line in markDown)
        {
            if (line.Trim().StartsWith("|"))
            {
                markDownTable = new MarkDownTableModel();
                var lineChar = line.Trim().ToCharArray();

                // parse the header first
                for (var i = 1; i < lineChar.Length; i++)
                {

                }
            }
        }
        return markDownTable;
    }
}
