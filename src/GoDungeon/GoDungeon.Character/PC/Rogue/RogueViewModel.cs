using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Rogue
{
    public class RogueViewModel : CharacterClassBaseViewModel
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
        public RogueViewModel(
            ILoggerFactory loggerFactory)
        {
            Name = nameof(RogueViewModel);
            Description =
                "Life is an endless adventure for those who live by " +
                "their wits.Ever just one step ahead of danger, rogues " +
                 "bank on their cunning, skill, and charm to bend fate " +
                "to their favor. Never knowing what to expect, they prepare " +
                "for everything, becoming masters of a wide variety of skills, " +
                "training themselves to be adept manipulators, agile acrobats, " +
                "shadowy stalkers, or masters of any of dozens of other " +
                "professions or talents. Thieves and gamblers, fast talkers " +
                "and diplomats, bandits and bounty hunters, and explorers " +
                "and investigators all might be considered rogues, as well " +
                "as countless other professions that rely upon wits, prowess, " +
                "or luck. Although many rogues favor cities and the " +
                "innumerable opportunities of civilization, some embrace " +
                "lives on the road, journeying far, meeting exotic people, " +
                "and facing fantastic danger in pursuit of equally fantastic " +
                "riches. In the end, any who desire to shape their fates and " +
                "live life on their own terms might come to be called rogues.";
        }
    }
}
