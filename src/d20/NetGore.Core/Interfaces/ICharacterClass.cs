using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

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
}