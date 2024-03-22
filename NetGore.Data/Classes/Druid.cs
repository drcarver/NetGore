using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Druid : DataObject, ICharacterClass
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
    public Druid()
    {
        Name = nameof(Druid);
        Description = "While some druids might " +
            "keep to the fringe of battle, " +
            "allowing companions and summoned " +
            "creatures to fight while they " +
            "confound foes with the powers of " +
            "nature, others transform into " +
            "deadly beasts and savagely wade " +
            "into combat. Druids worship " +
            "personifications of elemental " +
            "forces, natural powers, or nature " +
            "itself. Typically this means " +
            "devotion to a nature deity, though " +
            "druids are just as likely to revere " +
            "vague spirits, animalistic demigods, " +
            "or even specific awe-inspiring natural " +
            "wonders.";
        HitDice = "1d8";
        Class = ClassEnum.Druid;
        Level = 1;
    }
}
