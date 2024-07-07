using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Abilities
{
    /// <summary>
    /// Charisma measures your ability to interact effectively 
    /// with others. It includes such factors as confidence 
    /// and eloquence, and it can represent a charming or 
    /// commanding personality.
    /// </summary>
    public class Charisma : AbilityBaseViewModel
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Charisma(ICreature creature)
            : base(creature)
        {
            Name = "Charisma";
            Description = "Charisma measures your ability to interact effectively with others. It includes such factors as confidence and eloquence, and it can represent a charming or commanding personality.";
            Abbreviation = "CHA";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Charisma(int baseAbility, ICreature creature)
            : this(creature)
        {
            SetBaseAbility(baseAbility);
        }
    }
}