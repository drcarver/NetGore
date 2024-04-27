using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces
{
    public interface IArmorEntry : IEquipmentTableEntry
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
}