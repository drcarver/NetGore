using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Fighter : DataObject, ICharacterClass
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
    public Fighter()
    {
        Name = nameof(Fighter);
        Description = "Fighters excel at " +
              "combat—defeating their enemies, " +
              "controlling the flow of battle, " +
              "and surviving such sorties " +
              "themselves. While their specific " +
              "weapons and methods grant them a " +
              "wide variety of tactics, few can " +
              "match fighters for sheer battle " +
              "prowess.";
        HitDice = "1d10";
        Class = ClassEnum.Fighter;
        Level = 1;
    }
}
