using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Paladin : DataObject, ICharacterClass
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
    public Paladin()
    {
        Name = nameof(Paladin);
        Description = " Paladins serve as " +
            "beacons for their allies within " +
            "the chaos of battle. While " +
            "deadly opponents of evil, they " +
            "can also empower goodly souls " +
            "to aid in their crusades. Their " +
            "magic and martial skills also " +
            "make them well suited to defending " +
            "others and blessing the fallen " +
            "with the strength to continue " +
            "fighting.";
        HitDice = "1d10";
        Class = ClassEnum.Paladin;
        Level = 1;
    }
}
