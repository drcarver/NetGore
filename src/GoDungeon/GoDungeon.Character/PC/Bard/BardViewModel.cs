using System.Collections.Generic;

using GoDungeon.Character.Models;
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
        private List<ClassPrerequisiteModel> classPrerequisites = new List<ClassPrerequisiteModel>
        {
            new ClassPrerequisiteModel { Ability = AbilityEnum.Charisma, Score = 13}
        };

        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public override void LevelUp(ICharacterClass character)
        {
            base.LevelUp(character);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public BardViewModel(
            ILoggerFactory loggerFactory)
        {
            ClassEnum = Core.Enum.ClassEnum.Bard;
            Name = nameof(Core.Enum.ClassEnum.Bard);
            Description =
                "Bards have a talent for song and story, and they come to " +
                "their careers by developing this talent as they pick up " +
                "on a smattering of other skills.";
            classPrerequisites.Add(
                new ClassPrerequisiteModel
                {
                    Ability = AbilityEnum.Charisma,
                    Score = 13,
                });
            LevelUp(this);
        }
    }

}   