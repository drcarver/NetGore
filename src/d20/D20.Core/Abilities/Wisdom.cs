using D20.Core.Models;

namespace D20.Core.Abilities
{
    /// <summary>
    /// Wisdom reflects how attuned you are to the world 
    /// around you and represents perceptiveness and 
    /// intuition.
    /// </summary>
    public class Wisdom : AbilityBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Wisdom(Creature parent)
            : base(parent)
        {
            Name = "Wisdom";
            Description = "Wisdom reflects how attuned you are to the world around you and represents perceptiveness and intuition.";
            Abbreviation = "WIS";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Wisdom(int baseAbility, Creature parent)
            : base(baseAbility, parent)
        {
            Name = "Wisdom";
            Description = "Wisdom reflects how attuned you are to the world around you and represents perceptiveness and intuition.";
            Abbreviation = "WIS";
        }
    }
}
