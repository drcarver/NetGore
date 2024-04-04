using System.Diagnostics.CodeAnalysis;
using NetGore.Data.Enum;
using NetGore.Data.Models;

namespace NetGore.Items;

public class ArmorEntry : GameTableEntry, IArmorEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ArmorEntry()
    {
    }

    /// <summary>
    /// The armor proficiency enumerated type
    /// </summary>
    public ArmorCategoryEnum ArmorCategoryEnum { get; set; }

    /// <summary>
    /// The maximum dexterity for the armor
    /// </summary>
    public int? MaxDexterity { get; set; }

    /// <summary>
    /// The strength ability score required for
    /// the armor
    /// </summary>
    public int? Strength { get; set; }

    /// <summary>
    /// Is stealth possible in this armor
    /// </summary>
    public bool Stealth { get; set; }

    /// <summary>
    /// The weight of the armor in pounds
    /// </summary>
    public int Weight { get; set; }

    /// <summary>
    /// The cost of the armor in gold pieces
    /// </summary>
    public int Cost { get; set; }

    /// <summary>
    /// Armor Class(AC). Armor protects its wearer  
    /// from attacks. The armor (and shield) you wear
    /// determines your base Armor Class.
    /// </summary>
    public int AC { get; internal set; }
}
