using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Abilities
{
    /// <summary>
    /// Strength measures bodily power, athletic training, 
    /// and the extent to which you can exert raw physical 
    /// force.
    /// </summary>
    public class Strength : AbilityBaseViewModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Strength(ICreature parent)
            : base(parent)
        {
            Name = "Strength";
            Description = "Strength measures bodily power, athletic training, and the extent to which you can exert raw physical force.";
            Abbreviation = "STR";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Strength(int baseAbility, ICreature parent)
            : this(parent)
        {
            SetBaseAbility(baseAbility);
        }
    }
}
