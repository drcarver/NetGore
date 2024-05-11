using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Models;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Character.Models
{
    /// <summary>
    /// The class prerequisites.  The abilities required 
    /// for the class
    /// </summary>
    public partial class ClassPrerequisiteModel : BaseObjectModel, IClassPrerequisite
    {
        /// <summary>
        /// The Abbreviation for the ability
        /// </summary>
        public AbilityEnum Ability { get; set; }

        /// <summary>
        /// The ability score
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Does the creature have a high enough ability score?
        /// </summary>
        /// <param name="creature">The creature to test</param>
        /// <returns>True if the ability is high enough</returns>
        public bool AbilityAcceptable(ICreature creature)
        {
            switch (Ability)
            {
                case AbilityEnum.Strength:
                    return creature.Strength.BaseAbility +
                        creature.Strength.RacialModifier >= Score;
                case AbilityEnum.Intelligence:
                    return creature.Intelligence.BaseAbility +
                        creature.Intelligence.RacialModifier >= Score;
                case AbilityEnum.Wisdom:
                    return creature.Wisdom.BaseAbility +
                        creature.Wisdom.RacialModifier >= Score;
                case AbilityEnum.Dexterity:
                    return creature.Dexterity.BaseAbility +
                        creature.Dexterity.RacialModifier >= Score ||
                    -1 * (creature.Dexterity.BaseAbility +
                        creature.Dexterity.RacialModifier) <= Score;
                case AbilityEnum.Constitution:
                    return creature.Constitution.BaseAbility +
                        creature.Constitution.RacialModifier >= Score;
                case AbilityEnum.Charisma:
                    return creature.Charisma.BaseAbility +
                        creature.Charisma.RacialModifier >= Score;
            }
            return true;
        }
    }
}