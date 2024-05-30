using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Ranger
{
    /// <summary>
    /// Rangers have a talent for song and story, and they come to 
    /// their careers by developing this talent as they pick up 
    /// on a smattering of other skills. 
    /// </summary>
    public class RangerViewModel : CharacterClassBaseViewModel
    {
        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public override void LevelUp(ICharacterRace character)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public RangerViewModel(
            ILoggerFactory loggerFactory)
        {
            ClassEnum = Core.Enum.ClassEnum.Ranger;
            Name = nameof(Core.Enum.ClassEnum.Ranger);
            Description =
                "Rangers have a talent for song and story, and they come to " +
                "their careers by developing this talent as they pick up " +
                "on a smattering of other skills.";
        }
    }
}
