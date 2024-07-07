using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Abilities
{
    /// <summary>
    /// Wisdom reflects how attuned you are to the world 
    /// around you and represents perceptiveness and 
    /// intuition.
    /// </summary>
    public class Wisdom : AbilityBaseViewModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Wisdom(ICreature parent)
            : base(parent)
        {
            Name = "Wisdom";
            Description = "Wisdom reflects how attuned you are to the world around you and represents perceptiveness and intuition.";
            Abbreviation = "WIS";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Wisdom(int baseAbility, ICreature parent)
            : this(parent)
        {
            SetBaseAbility(baseAbility);
        }
    }
}
