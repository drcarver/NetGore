using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Sorcerer
{
    /// <summary>
    /// Sorcerers have a talent for song and story, and they come to 
    /// their careers by developing this talent as they pick up 
    /// on a smattering of other skills. 
    /// </summary>
    public partial class SorcererViewModel : CharacterClassBaseViewModel
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
        public SorcererViewModel(
            ILoggerFactory loggerFactory)
        {
            Name = nameof(Sorcerer);
            Description =
                "Sorcerers have a talent for song and story, and they come to " +
                "their careers by developing this talent as they pick up " +
                "on a smattering of other skills.";
        }
    }
}
