using System.IO;

using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IGenerateModel
{
    /// <summary>
    /// the list of MarkDownTables.
    /// </summary>
    List<UseGoDungeonModel> GoDungeonModelList { get; }

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
    /// <param name="filePath">The file path to the markdown file</param>
    /// <param name="tableName">The name of the table to generate</param>
    /// <param name="properties">The list of properties for the view model</param>
    /// <param name="rows">The rows of the table</param>
    /// <param name="nameSpace">The nameSPace for the table</param>
    public void GenerateTable(string dirPath, string filePath, string tableName, List<PropertyModel> properties, List<List<string>> rows, string nameSpace);

    /// <summary>
    /// Generate the list files
    /// </summary>
    /// <param name="spellInfoList">The spell info list</param>
    /// <param name="rootdir">The rootDir</param>
    void GenerateSpellLists(List<ISpellTableEntry> spellInfoList, string rootDir);

    /// <summary>
    /// Generate the constructor for the main view model
    /// </summary>
    /// <param name="outputDir">The output directory</param>
    /// <param name="model">The mark down table model</param>
    /// <param name="filePath">The path to the output file</param>
    void GenerateConstructor(string outputDir, IMarkDownTableModel model, string filePath);

    /// <summary>
    /// Generate the Service Collection extension for the namespace
    /// </summary>
    /// <param name="stream">The output stream</param>
    /// <param name="model">The GoDungeon model file</param>
    void GenerateServicesCollectionExtension(TextWriter stream, UseGoDungeonModel model);
}
