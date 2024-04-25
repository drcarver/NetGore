using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Abilities
{
    /// <summary>
    /// Constitution measures health, stamina, and vital 
    /// force.
    /// </summary>
    public class Constitution : AbilityBaseViewModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Constitution(ICreature parent)
            : base(parent)
        {
            Name = "Constitution";
            Description = "Constitution measures health, stamina, and vital force.";
            Abbreviation = "CON";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Constitution(int baseAbility, ICreature parent)
            : base(baseAbility, parent)
        {
            Name = "Constitution";
            Description = "Constitution measures health, stamina, and vital force.";
            Abbreviation = "CON";
        }
    }
}
