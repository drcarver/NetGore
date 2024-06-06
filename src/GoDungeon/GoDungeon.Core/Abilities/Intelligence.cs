using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Core.Abilities
{
    /// <summary>
    /// Intelligence measures mental acuity, accuracy of recall,
    /// and the ability to reason.
    /// </summary>
    public class Intelligence : AbilityBaseViewModel
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
            : this(parent)
        {
            SetBaseAbility(baseAbility);
        }
    }
}
