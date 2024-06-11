using GoDungeon.Core.Interfaces;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IGenerateHtml
{
    /// <summary>
    /// Generate the .html for the class
    /// </summary>
    /// <param name="markDown">The markdown file as a series of strings</param>
    /// <param name="writer">The StreamWriter stream</param>
    /// <param name="classInfo">The creature</param>
    void GenerateMonsterHtmlFiles(StreamWriter writer, ICreature creature);

    /// <summary>
    /// Generate the .html for the class
    /// </summary>
    /// <param name="markDown">The markdown file as a series of strings</param>
    /// <param name="writer">The StreamWriter stream</param>
    /// <param name="classInfo">The creature</param>
    void GenerateSpellHtmlFiles(StreamWriter writer, ISpellTableEntry creature);
}
