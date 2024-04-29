using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Models;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Character.ViewModels
{
    /// <summary>
    /// The class prerequisites.  The abilities required 
    /// for the class
    /// </summary>
    public partial class ClassPrerequisiteViewModel : BaseObjectViewModel, IClassPrerequisite
    {
        /// <summary>
        /// The Abbreviation for the ability
        /// </summary>
        [ObservableProperty]
        private AbilityEnum ability;

        /// <summary>
        /// The ability score
        /// </summary>
        [ObservableProperty]
        private int score;

        /// <summary>
        /// Does the ability have a high enough score?
        /// </summary>
        /// <param name="creature">The creature to test</param>
        /// <returns>True if the ability is high enough</returns>
        public bool AbilityAcceptable(ICreature creature)
        {
            switch (Ability)
            {
                case AbilityEnum.Strength:
                    return Score >= creature.Strength.BaseAbility +
                        creature.Strength.RacialModifier;
                case AbilityEnum.Intelligence:
                    return Score >= creature.Intelligence.BaseAbility +
                        creature.Intelligence.RacialModifier;
                case AbilityEnum.Wisdom:
                    return Score >= creature.Wisdom.BaseAbility +
                        creature.Wisdom.RacialModifier;
                case AbilityEnum.Dexterity:
                    return Score >= creature.Dexterity.BaseAbility +
                        creature.Dexterity.RacialModifier;
                case AbilityEnum.Constitution:
                    return Score >= creature.Constitution.BaseAbility +
                        creature.Constitution.RacialModifier;
                case AbilityEnum.Charisma:
                    return Score >= creature.Charisma.BaseAbility +
                        creature.Charisma.RacialModifier;

            }
            return false;
        }
    }
}