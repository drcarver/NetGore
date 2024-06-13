using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.ViewModels;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IParseMarkdown
{
    /// <summary>
    /// Get the monster from the markDown file
    /// </summary>
    IMarkDownTableModel? ParseMarkDownTable(List<string> markDown);

    /// <summary>
    /// Get the monster from the markDown file
    /// </summary>
    ICreature? ParseMonster(List<string> markDown);

    /// <summary>
    /// Get the spell from the markDown file
    /// </summary>
    ISpellTableEntry? ParseSpell(List<string> markDown);

    /// <summary>
    /// The monster information
    /// </summary>
    List<ICreature> CreatureList { get; }

    /// <summary>
    /// A list of monster Info
    /// </summary>
    List<MonsterInfoViewModel> MonsterInfoList { get; }

    /// <summary>
    /// The spell list
    /// </summary>
    List<ISpellTableEntry> SpellInfoList { get; set; }

    /// <summary>
    /// The root directory to generate the .html and class files in
    /// </summary>
    string? RootDirectory { get; set; }
}
