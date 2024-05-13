using GoDungeon.Character.Models;
using GoDungeon.Character.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Character.PC.Monk
{
    public class Monk : CharacterClassBaseViewModel
    {
        /// <summary>
        /// Level up the character with this class
        /// </summary>
        /// <param name="character"></param>
        public override void LevelUp(ICharacterRace character)
        {
            ////Skills: Choose two
            //int newSkillCount = 0;
            //for (int i = 0; i < Skills.Count; i++)
            //{
            //    var dice = new Dice($"1d{Skills.Count}").Total;
            //    if (!character.Skills.Contains(Skills{dice}))
            //    {
            //        newSkillCount++;
            //        if (newSkillCount > 2)
            //        {
            //            break;
            //        }
            //        character.Skills.Add(Skills{dice});
            //    }
            //}

            //character.Equipment.Add(new Ammunition( )
            //Equipment
            //You start   with the following equipment,  in	addition
            //to  the equipment   granted by  your background:
            //• (a) a   shortsword or(b) any simple  weapon
            //• (a) a   dungeoneer’s pack    or(b) an explorer’s pack
            //• 10	darts
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Monk(
            ILoggerFactory loggerFactory)
        {
            ClassEnum = Core.Enum.ClassEnum.Monk;
            Name = nameof(Core.Enum.ClassEnum.Monk);
            Description =
                "Monks excel at overcoming even the most daunting " +
                "perils, striking where it’s least expected, and " +
                "taking advantage of enemy vulnerabilities. Fleet " +
                "of foot and skilled in combat, monks can navigate " +
                "any battlefield with ease, aiding allies wherever " +
                "they are needed most.";
            classPrerequisites.Add(
                new ClassPrerequisiteModel
                {
                    Ability = AbilityEnum.Wisdom,
                    Score = 13,
                });
            classPrerequisites.Add(
                new ClassPrerequisiteModel
                {
                    Ability = AbilityEnum.Dexterity,
                    Score = 13,
                });
        }
    }

}
