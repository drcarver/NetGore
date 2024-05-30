using System;

using GoDungeon.Character.Interfaces;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.ViewModels
{
    public class PlayerCharacterViewModel : CharacterViewModel, ICharacter
    {
        /// <summary>
        /// The Player Character
        /// </summary>
        /// <param name="loggerFactory">The logger service</param>
        /// <param name="serviceProvider">The DI Container</param>
        public PlayerCharacterViewModel(
            ILoggerFactory loggerFactory,
            IServiceProvider serviceProvider,
            IClassService classService,
            ICharacterAdvancementTable characterAdvancement)
            : base(serviceProvider, loggerFactory)
        {
            classService.SetClass(this);
        }
    }
}