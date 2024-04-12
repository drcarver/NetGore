using System.Diagnostics.CodeAnalysis;

using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class ArmorEntry : EquipmentEntry, IArmorEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ArmorEntry()
    {
    }

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
    /// Armor Class(AC). Armor protects its wearer  
    /// from attacks. The armor (and shield) you wear
    /// determines your base Armor Class.
    /// </summary>
    public int AC { get; internal set; }
}
