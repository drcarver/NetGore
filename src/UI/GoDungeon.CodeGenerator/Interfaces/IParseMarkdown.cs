using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.ViewModels;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IParseMonsterMarkdown
{
    /// <summary>
    /// Get the monster from the markDown file
    /// </summary>
    public ICreature ParseMonster(List<string> markDown);

    /// <summary>
    /// The monster information
    /// </summary>
    public List<ICreature> CreatureList { get; }

    /// <summary>
    /// A list of monster Info
    /// </summary>
    public List<MonsterInfoViewModel> MonsterInfoList { get; }
}
