using GoDungeon.CommandLineTools.Models;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.CommandLineTools.Interfaces;

public interface IParseMonsterMarkdown
{
    /// <summary>
    /// Get the monster from the markDown file
    /// </summary>
    public void ParseMonster(List<string> markDown);

    /// <summary>
    /// The monster information
    /// </summary>
    public List<ICreature> CreatureList { get; }

    /// <summary>
    /// A list of monster Info
    /// </summary>
    public List<MonsterInfo> MonsterInfoList { get; }
}
