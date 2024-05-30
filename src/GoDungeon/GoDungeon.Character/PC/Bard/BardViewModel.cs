using System.Collections.Generic;

using GoDungeon.Character.Models;
using GoDungeon.Character.PC.Barbarian;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.ViewModels;

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
        public override void LevelUp(ICharacterRace character)
        {
            base.LevelUp(character);
            if (Level == 0)
            {
                Initialize(character);
            }
        }

        /// <summary>
        /// Initialize the class
        /// </summary>
        /// <param name="character"></param>
        protected override void Initialize(ICharacterRace character)
        {
            base.Initialize(character);

            SavingThrows.Add(new SavingThrowViewModel(character.Strength));
            SavingThrows.Add(new SavingThrowViewModel(character.Dexterity, true));
            SavingThrows.Add(new SavingThrowViewModel(character.Constitution));
            SavingThrows.Add(new SavingThrowViewModel(character.Intelligence));
            SavingThrows.Add(new SavingThrowViewModel(character.Wisdom));
            SavingThrows.Add(new SavingThrowViewModel(character.Charisma, true));
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public BardViewModel(
            ILoggerFactory loggerFactory,
            IBardLevelTable bardLevelTable,
            IBardBackgroundTable bardBackgroundTable)
        {
            ClassEnum = Core.Enum.ClassEnum.Bard;
            Name = nameof(Core.Enum.ClassEnum.Bard);
            Description =
                "Bards have a talent for song and story, and they come to " +
                "their careers by developing this talent as they pick up " +
                "on a smattering of other skills.";
        
            // The class level table for this class
            ClassLevelTable = bardLevelTable;
            BackgroundTable = bardBackgroundTable;
        }
    }

}   