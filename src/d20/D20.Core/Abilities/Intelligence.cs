using D20.Core.Interfaces;

namespace D20.Core.Abilities
{
    /// <summary>
    /// Intelligence measures mental acuity, accuracy of recall,
    /// and the ability to reason.
    /// </summary>
    public class Intelligence : AbilityBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Intelligence(ICreature parent)
            : base(parent)
        {
            Name = "Intelligence";
            Description = "Intelligence measures mental acuity, accuracy of recall, and the ability to reason.";
            Abbreviation = "INT";
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Intelligence(int baseAbility, ICreature parent)
            : base(baseAbility, parent)
        {
            Name = "Intelligence";
            Description = "Intelligence measures mental acuity, accuracy of recall, and the ability to reason.";
            Abbreviation = "INT";
        }
    }
}
