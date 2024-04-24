using D20.Core.Models;

namespace D20.Core.Abilities
{
    /// <summary>
    /// Dexterity measures agility, reflexes, and balance.
    /// </summary>
    public class Dexterity : AbilityBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Dexterity(Creature parent)
            : base(parent)
        {
            Name = "Dexterity";
            Description = "Dexterity measures agility, reflexes, and balance.";
            Abbreviation = "DEX";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Dexterity(int baseAbility, Creature parent)
            : base(baseAbility, parent)
        {
            Name = "Dexterity";
            Description = "Dexterity measures agility, reflexes, and balance.";
            Abbreviation = "DEX";
        }
    }
}
