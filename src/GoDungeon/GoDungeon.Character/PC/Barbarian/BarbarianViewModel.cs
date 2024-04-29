using GoDungeon.Character.ViewModels;
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
        public override void LevelUp(ICharacter character)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public BarbarianViewModel(ILoggerFactory loggerFactory)
        {
            Name = nameof(BarbarianViewModel);
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
        }
    }
}
