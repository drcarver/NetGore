using D20.Core.Interfaces;

namespace D20.Goods.Interfaces;

public interface IArmorEntry : IGameTableEntry
{
    /// <summary>
    /// The Armor class of the armor
    /// </summary>
    int AC { get; }

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
}