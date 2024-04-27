// Ignore Spelling: Dragonborn

using System.Diagnostics.CodeAnalysis;

using D20.Core;
using D20.Core.Enum;
using D20.Core.Models;
using D20.Monsters.Interfaces;
using D20.Monsters.Models;

using GoDungeon.Character.Interfaces;

using Microsoft.Extensions.Logging;

namespace D20.Character.Race;

public class Dragonborn : CharacterRace, ICharacterRace
{
    /// <summary>
    /// Set the race traits for the 
    /// </summary>
    /// <param name="creature"></param>
    [SetsRequiredMembers]
    public Dragonborn(LoggerFactory loggerFactory)
        : base(loggerFactory)
    {
        Race = RaceEnum.Dragonborn;

        // Ability Score Increase.Your Strength
        // score increases by 2, and your Charisma
        // score increases by 1.
        Strength.RacialModifier += 2;
        Charisma.RacialModifier += 1;

        //Size.Dragonborn are taller and heavier
        //than humans, standing well over 6 feet
        //tall and averaging almost 250 pounds.
        //Your size is Medium.
        SetHeightAndWeight();
        Size = SizeEnum.Medium;

        //Speed.Your base walking speed is 30 feet.
        Speed = 30;

        //Type: Dragonborn are humanoids with the
        //Dragonborn subtype.
        RaceType = RaceType.Humanoid;
        RaceSubType.Add(RaceSubTypeEnum.Dragonborn);

        // Languages. You can speak, read, and write
        // Common and Draconic. Draconic is thought
        // to be one of the oldest languages and is
        // often used in the study of magic.
        // The language sounds harsh to most other
        // creatures and includes numerous hard
        // consonants and sibilants.
        Languages.Add(LanguageEnum.Common);
        Languages.Add(LanguageEnum.Draconic);
    }

    //Table: Random Height and Weight
    //Gender Base Height   Height Modifier Base Weight Weight Modifier
    //Male	 6 ft. 2 in.	+2d8 in.        100 lbs.    +(2d8×5 lbs.)
    //Female 6 ft. 0 in.	+2d8 in.         90 lbs.    +(2d8×5 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private void SetHeightAndWeight(ICharacter creature)
    {
        if (creature?.Gender == GenderEnum.Male)
        {
            var modifier = new Dice("2d8").Total;
            if (modifier <= 9)
            {
                Height = new Height(6 + modifier, 2);
            }
            else if (modifier == 10)
            {
                Height = new Height(7, 0);
            }
            else
            {
                Height = new Height(7, modifier - 10);
            }
            // 100 lbs. +(2d8×5 lbs.)
            Weight = 200 + new Dice("2d8").Total * 5;
        }

        if (creature?.Gender == GenderEnum.Female)
        {
            var modifier = new Dice("2d8").Total;
            if (modifier <= 11)
            {
                Height = new Height(5, modifier);
            }
            else if (modifier == 12)
            {
                Height = new Height(6, 0);
            }
            else
            {
                Height = new Height(6, modifier - 12);
            }
            // 180 lbs. +(2d8×5 lbs.)
            Weight = 180 + new Dice("2d8").Total * 5;
        }
    }

    // Table: Random Starting Ages
    // Adulthood   Intuitive1 Self-Taught2 Trained3
    // 15 years	   +1d6 years  +2d6 years  +3d6 years
    /// <summary>
    /// Set the age
    /// </summary>
    /// <param name="creature"></param>
    private static void SetAge(ICharacter creature)
    {
    }
}