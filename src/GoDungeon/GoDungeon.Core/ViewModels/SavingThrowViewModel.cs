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
        /// True if specific to the class
        /// </summary>
        [ObservableProperty]
        private bool isClassSavingThrow;

        /// <summary>
        /// Any Other modifiers
        /// </summary>
        [ObservableProperty]
        private int otherModifiers = 0;

        /// <summary>
        /// Any race modifiers
        /// </summary>
        [ObservableProperty]
        private int racialModifier;

        /// <summary>
        /// Roll the saving throw against the give dc
        /// </summary>
        /// <param name="dc">The difficulty check for this roll</param>
        /// <returns>True if the saving throw succeeds</returns>
        public bool Roll(int dc, int proficiencyModifier = 0)
        {
            var roll = new Dice("1GoDungeon").Total;
            if (roll == 1)
            {
                return false;
            }
            if (roll == 20)
            {
                return true;
            }
            return roll
                + RacialModifier
                + proficiencyModifier
                + OtherModifiers
                + Ability.Score >= dc;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="creature">The creature with the saving throw</param>
        /// <param name="ability">The ability for the saving throw</param>
        public SavingThrowViewModel(
            ICreature creature, 
            IAbilityBase ability)
        {
            Ability = ability;
            Creature = creature;
        }
    }
}
