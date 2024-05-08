using System.Collections.Generic;

using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Bard
{
    /// <summary>
    /// Bards have a talent for song and story, and they come to 
    /// their careers by developing this talent as they pick up 
    /// on a smattering of other skills. 
    /// </summary>
    public class BardViewModel : CharacterClassBaseViewModel, IBard
    {
        private List<ClassPrerequisiteViewModel> classPrerequisites = new List<ClassPrerequisiteViewModel>
        {
            new ClassPrerequisiteViewModel { Ability = AbilityEnum.Charisma, Score = 13}
        };

        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public override void LevelUp(ICharacterClass character)
        {
            foreach (var classPrerequisite in classPrerequisites)
            {
                if (!classPrerequisite.AbilityAcceptable(character))
                {
                    return;
                }
            }

            base.LevelUp(character);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public BardViewModel(
            ILoggerFactory loggerFactory)
        {
            Name = nameof(BardViewModel);
            Description =
                "Bards have a talent for song and story, and they come to " +
                "their careers by developing this talent as they pick up " +
                "on a smattering of other skills.";
            LevelUp(this);
        }
    }

}   