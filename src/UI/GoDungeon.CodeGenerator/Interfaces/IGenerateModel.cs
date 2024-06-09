using GoDungeon.Core.Interfaces;
using GoDungeon.Spells.Interfaces;
using GoDungeon.Spells.ViewModels;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IGenerateModel
{
    /// <summary>
    /// Generate the .cs class for the monster
    /// </summary>
    /// <param name="stream">The text stream to write the main monster file to</param>
    /// <param name="creature">The creature to create a .cs class for</param>
    /// <param name="rootDir">The root dir for the monster file</param>
    void GenerateMonsterClass(TextWriter stream, ICreature creature, string rootDir);

    /// <summary>
    /// Generate the .cs class for the spell
    /// </summary>
    /// <param name="stream">The text stream to write the main monster file to</param>
    /// <param name="spell">The spell to create a .cs class for</param>
    /// <param name="rootDir">The root dir for the spell file</param>
    void GenerateSpellClass(TextWriter stream, ISpell spell, string rootDir);

    /// <summary>
    /// Generate the list files
    /// </summary>
    /// <param name="spellInfoList">The spell info list</param>
    /// <param name="rootdir">The rootdir</param>
    void GenerateSpellLists(List<SpellInfoViewModel> spellInfoList, string rootdir);
}
