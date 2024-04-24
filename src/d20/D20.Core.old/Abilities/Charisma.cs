using D20.Core.Interfaces;


namespace D20.Core.Abilities
{
    /// <summary>
    /// Charisma measures your ability to interact effectively 
    /// with others. It includes such factors as confidence 
    /// and eloquence, and it can represent a charming or 
    /// commanding personality.
    /// </summary>
    public class Charisma : AbilityBase
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
            : base(baseAbility, creature)
        {
            Name = "Charisma";
            Description = "Charisma measures your ability to interact effectively with others. It includes such factors as confidence and eloquence, and it can represent a charming or commanding personality.";
            Abbreviation = "CHA";
        }
    }
}