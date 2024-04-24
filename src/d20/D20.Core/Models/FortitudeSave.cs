using System.Diagnostics.CodeAnalysis;

namespace D20.Core.Models
{
    public class FortitudeSave : SavingThrow
    {
        /// <summary>
        /// Fortitude Save
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="creature">The creature the save is for</param>
        public FortitudeSave(Creature creature)
            : base(creature, creature.Constitution)
        {
            Name = "Fortitude Save";
            Description = "These saves measure your ability " +
                "to stand up to physical punishment or " +
                "attacks against your vitality and health. " +
                "Apply your Constitution modifier to your " +
                "Fortitude saving throws.";
        }
    }
}
