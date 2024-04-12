using D20.Character.Enum;
using D20.Character.Models;

namespace D20.Character.Interfaces;

public interface ICharacterClass
{
    /// <summary>
    /// The class enum
    /// </summary>
    ClassEnum ClassEnum { get; set; }

    /// <summary>
    /// The class prerequisites
    /// </summary>
    List<ClassPrerequisite> ClassPrerequisites { get; set; }

    /// <summary>
    /// The hit dice for the class
    /// </summary>
    string HitDice { get; set; }

    /// <summary>
    /// The class level
    /// </summary>
    int Level { get; set; }
}