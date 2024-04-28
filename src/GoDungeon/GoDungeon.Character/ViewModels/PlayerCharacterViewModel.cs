using GoDungeon.Character.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.ViewModels
{
    public class PlayerCharacterViewModel : CharacterViewModel, ICharacter
    {
        /// <summary>
        /// The Player Character
        /// </summary>
        /// <param name="loggerFactory">The logger service</param>
        /// <param name="raceService">Race Service</param>
        /// <param name="classService">Class service</param>
        public PlayerCharacterViewModel(
            ILoggerFactory loggerFactory,
            IClassService classService,
            ICharacterAdvancementTable characterAdvancement)
        {
            classService.SetClass(this);
        }
    }
}