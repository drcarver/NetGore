using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Paladin
{
    /// <summary>
    /// Paladins have a talent for song and story, and they come to 
    /// their careers by developing this talent as they pick up 
    /// on a smattering of other skills. 
    /// </summary>
    public partial class PaladinViewModel : CharacterClassBaseViewModel
    {
        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public void LevelUp(ICharacter character)
        {
       }

        /// <summary>
        /// Constructor
        /// </summary>
        public PaladinViewModel(
            ILoggerFactory loggerFactory)
        {
            Name = nameof(PaladinViewModel);
            Description =
                "Paladins have a talent for song and story, and they come to " +
                "their careers by developing this talent as they pick up " +
                "on a smattering of other skills.";
        }
    }

    //Tools: Three musical instruments of  your choice
    //Skills: Choose any three
    //Equipment
    //You start   with the following equipment,  in	addition
    //to  the equipment   granted by  your background:
    //• (a) a   rapier,	(b) a   longsword,	or(c) any simple
    //weapon
    //• (a) a   diplomat’s pack    or(b) an entertainer’s pack
    //• (a) a   lute or(b) any other   musical instrument
    //• Leather armor   and a   dagger
    //The Paladin
}
