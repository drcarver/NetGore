using GoDungeon.Character.Models;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Barbarian
{
    public class BarbarianViewModel : CharacterClassBaseViewModel, IBarbarian
    {
        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public override void LevelUp(ICharacterClass character)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        public BarbarianViewModel(ILoggerFactory loggerFactory)
        {
            ClassEnum = Core.Enum.ClassEnum.Barbarian;
            Name = nameof(Core.Enum.ClassEnum.Barbarian);
            Description = "Barbarians excel in " +
                "combat, possessing the martial " +
                "prowess and fortitude to take " +
                "on foes seemingly far superior " +
                "to themselves. With rage granting " +
                "them boldness and daring beyond " +
                "that of most other warriors, " +
                "barbarians charge furiously into " +
                "battle and ruin all who would " +
                "stand in their way.";
            classPrerequisites.Add(
                new ClassPrerequisiteModel
                {
                    Ability = AbilityEnum.Strength,
                    Score = 13,
                });
        }
    }
}
