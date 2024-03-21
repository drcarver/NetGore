using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Data.Classes;

public class Warlock : DataObject, ICharacterClass
{
    /// <summary>
    /// The class enum
    /// </summary>
    public ClassEnum Class { get; set; }

    /// <summary>
    /// The level in the class (can be different
    /// from the characer level for multiclass 
    /// characters).
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The hit dice for the class
    /// </summary>
    public string HitDice { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Warlock()
    {
        Name = nameof(Warlock);
        Description = "Warlocks cast spells with" +
            "with their charisma modifier and " +
            "otherworldly Patrons";
        HitDice = "1d6";
        Class = ClassEnum.Warlock;
        Level = 1;
    }
}
