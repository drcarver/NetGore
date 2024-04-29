using System.Diagnostics.CodeAnalysis;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    public class FortitudeSaveViewModel : SavingThrowViewModel
    {
        /// <summary>
        /// Fortitude Save
        /// </summary>
        /// <param name="logger">The logger</param>
        /// <param name="creature">The creature the save is for</param>
        public FortitudeSaveViewModel(ICreature creature)
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
