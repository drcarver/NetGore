using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Abilities;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    public partial class SavingThrowViewModel : BaseObjectViewModel, ISavingThrow
    {
        /// <summary>
        /// The creature for this saving throw
        /// </summary>
        [ObservableProperty]
        private ICreature creature;

        /// <summary>
        /// The ability this saving throw is based on
        /// </summary>
        [ObservableProperty]
        private IAbilityBase ability;

        /// <summary>
        /// The modifier for this saving throw (mainly from
        /// the level
        /// </summary>
        [ObservableProperty]
        private int proficiencyModifier = 0;

        /// <summary>
        /// Any class modifiers
        /// </summary>
        [ObservableProperty]
        private int classModifier = 0;

        /// <summary>
        /// Any Other modifiers
        /// </summary>
        [ObservableProperty]
        private int otherModifiers = 0;

        /// <summary>
        /// Roll the saving throw against the give dc
        /// </summary>
        /// <param name="dc">The difficulty check for this roll</param>
        /// <returns>True if the saving throw succeeds</returns>
        public bool Roll(int dc)
        {
            var roll = new Dice("1d20").Total;
            if (roll == 1)
            {
                return false;
            }
            if (roll == 20)
            {
                return true;
            }
            return roll + Ability.Score() >= dc;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ability">The ability for this saving throw</param>
        public SavingThrowViewModel(ICreature creature, IAbilityBase ability)
        {
            Ability = ability;
            Creature = creature;
        }
    }
}
