using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Abilities
{
    /// <summary>
    /// Dexterity measures agility, reflexes, and balance.
    /// </summary>
    public class Dexterity : AbilityBaseViewModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Dexterity(ICreature parent)
            : base(parent)
        {
            Name = "Dexterity";
            Description = "Dexterity measures agility, reflexes, and balance.";
            Abbreviation = "DEX";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Dexterity(int baseAbility, ICreature parent)
            : base(baseAbility, parent)
        {
            Name = "Dexterity";
            Description = "Dexterity measures agility, reflexes, and balance.";
            Abbreviation = "DEX";
        }
    }
}
