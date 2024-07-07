using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    public partial class SavingThrowViewModel : BaseObjectViewModel, ISavingThrow
    {
        /// <summary>
        /// The ability this saving throw is based on
        /// </summary>
        [ObservableProperty]
        private IAbilityBase ability;

        /// <summary>
        /// True if specific to the class
        /// </summary>
        [ObservableProperty]
        private bool isClassSavingThrow = false;

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
        /// <param name="proficiency">The proficiency for this saving throw</param>
        public bool Roll(int dc, int proficiency = 0)
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
            return roll
                + RacialModifier
                + proficiency
                + Ability.AbilityBonus
                + OtherModifiers
                + Ability.Score >= dc;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ability">The ability for the saving throw</param>
        public SavingThrowViewModel(IAbilityBase ability)
        {
            Ability = ability;
        }
    }
}
