using GoDungeon.Core.Enum;
using GoDungeon.Spells.Enum;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface ISpell : ICodeGen
{
    /// <summary>
    /// The level of the spell
    /// </summary>
    int Level { get; }

    /// <summary>
    /// The magic school for the spell
    /// </summary>
    MagicSchoolEnum MagicSchool { get; }

    /// <summary>
    /// The list of character classes for the spell
    /// </summary>
    List<ClassEnum> CharacterClassList {  get; }
}
