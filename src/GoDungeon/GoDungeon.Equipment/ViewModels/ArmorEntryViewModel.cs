using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class ArmorEntryViewModel : EquipmentTableEntryViewModel, IArmorEntry
    {
        /// <summary>
        /// The maximum dexterity for the armor
        /// </summary>
        [ObservableProperty]
        private int? maxDexterity;

        /// <summary>
        /// The strength ability score required for
        /// the armor
        /// </summary>
        [ObservableProperty]
        private int? strength;

        /// <summary>
        /// Is stealth possible in this armor
        /// </summary>
        [ObservableProperty]
        private bool stealth;

        /// <summary>
        /// Armor Class(AC). Armor protects its wearer  
        /// from attacks. The armor (and shield) you wear
        /// determines your base Armor Class.
        /// </summary>
        [ObservableProperty]
        private int aC;
    }
}
