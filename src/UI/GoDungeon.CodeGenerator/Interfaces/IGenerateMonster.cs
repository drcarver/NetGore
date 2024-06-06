using GoDungeon.Core.Interfaces;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IGenerateMonster
{
    /// <summary>
    /// Generate the .cs class for the monster
    /// </summary>
    /// <param name="stream">The text stream to write the main monster file to</param>
    /// <param name="creature">The creature to create a .cs class for</param>
    /// <param name="rootDir">The root dir for the monster file</param>
    void GenerateMonsterClass(TextWriter stream, ICreature creature, string rootDir);
}
