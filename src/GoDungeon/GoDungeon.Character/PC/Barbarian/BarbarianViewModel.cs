using System.ComponentModel.Design;

using GoDungeon.Character.Models;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Abilities;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Barbarian
{
    public class BarbarianViewModel : CharacterClassBaseViewModel, IBarbarian
    {
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

            // Class Saving throws
            SavingThrows.Add(new SavingThrowViewModel(character.Strength));
            SavingThrows.Add(new SavingThrowViewModel(character.Constitution));
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public BarbarianViewModel(ILoggerFactory loggerFactory,
            IBarbarianLevelTable barbarianLevelTable)
        {
            ClassEnum = Core.Enum.ClassEnum.Barbarian;
            Name = nameof(Core.Enum.ClassEnum.Barbarian);
            Description = "Barbarians excel in " +
                "combat, possessing the martial " +
                "prowess and fortitude to take " +
                "on foes seemingly far superior " +
                "to themselves. With rage granting " +
                "them boldness and daring beyond " +
                "that of most other warriors, " +
                "barbarians charge furiously into " +
                "battle and ruin all who would " +
                "stand in their way.";

            // The class level table for this class
            ClassLevelTable = barbarianLevelTable; 
        }
    }
}
