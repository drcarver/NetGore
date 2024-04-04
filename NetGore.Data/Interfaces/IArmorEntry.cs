using NetGore.Core.Interfaces;
using NetGore.Data.Enum;

namespace NetGore.Items;

public interface IArmorEntry : IGameTableEntry
{
    /// <summary>
    /// The Armor class of the armor
    /// </summary>
    int AC { get; }

    /// <summary>
    /// The Armor category (heavy, medium, light)
    /// </summary>
    ArmorCategoryEnum ArmorCategoryEnum { get; set; }
    
    /// <summary>
    /// The cost of the armor in gold pieces
    /// </summary>
    int Cost { get; set; }

    /// <summary>
    /// The max dexterity allowed in the armor
    /// </summary>
    int? MaxDexterity { get; set; }

    /// <summary>
    /// Does the armor allow for stealthy movement
    /// </summary>
    bool Stealth { get; set; }

    /// <summary>
    /// The strength required to wear the armor
    /// </summary>
    int? Strength { get; set; }

    /// <summary>
    /// The weight of the armor
    /// </summary>
    int Weight { get; set; }
}