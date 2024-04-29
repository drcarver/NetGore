using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Bard
{
    /// <summary>
    /// Bards have a talent for song and story, and they come to 
    /// their careers by developing this talent as they pick up 
    /// on a smattering of other skills. 
    /// </summary>
    public class Bard : CharacterClassBaseViewModel, IBard
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
        public Bard(
            ILoggerFactory loggerFactory)
        {
            Name = nameof(Bard);
            Description =
                "Bards have a talent for song and story, and they come to " +
                "their careers by developing this talent as they pick up " +
                "on a smattering of other skills.";
        }
    }

}   