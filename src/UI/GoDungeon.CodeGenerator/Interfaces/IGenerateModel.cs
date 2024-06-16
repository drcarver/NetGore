using GoDungeon.Core.Interfaces;
using GoDungeon.Spells.Interfaces;

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
    void GenerateSpellClass(TextWriter stream, ISpellTableEntry spell, string rootDir);

    /// <summary>
    /// Generate the .cs class for the spell
    /// </summary>
    /// <param name="dirPath">The directory path for the table</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="properties">The list of properties for the view model</param>
    /// <param name="rows">The rows of the table</param>
    /// <param name="nameSpace">The nameSPace for the table</param>
    public void GenerateTable(string dirPath, string tableName, List<string> properties, List<string> rows, string nameSpace);

    /// <summary>
    /// Generate the list files
    /// </summary>
    /// <param name="spellInfoList">The spell info list</param>
    /// <param name="rootdir">The rootDir</param>
    void GenerateSpellLists(List<ISpellTableEntry> spellInfoList, string rootDir);
}
