using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Monk : DataObject, ICharacterClass
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
    public Monk()
    {
        Name = nameof(Monk);
        Description = "Monks excel at " +
            "overcoming even the most daunting " +
            "perils, striking where it’s least " +
            "expected, and taking advantage of " +
            "enemy vulnerabilities. Fleet of " +
            "foot and skilled in combat, monks " +
            "can navigate any battlefield with " +
            "ease, aiding allies wherever they " +
            "are needed most.";
        HitDice = "1d8";
        Class = ClassEnum.Monk;
        Level = 1;
    }
}
