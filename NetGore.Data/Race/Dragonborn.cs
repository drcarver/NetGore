using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

public class Dragonborn : IRace
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Dragonborn(Character creature)
    {
        creature.RaceName = nameof(Dragonborn);
        creature.RaceDescription =
            "Your draconic heritage manifests in " +
            "a variety of traits you share with " +
            "other dragonborn.";

        // Ability Score Increase.Your Strength
        // score increases by 2, and your Charisma
        // score increases by 1.
        creature.Strength.RacialModifier += 2;
        creature.Charisma.RacialModifier += 1;

        //Size.Dragonborn are taller and heavier
        //than humans, standing well over 6 feet
        //tall and averaging almost 250 pounds.
        //Your size is Medium.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Medium;

        //Speed.Your base walking speed is 30 feet.
        creature.Speed = 30;

        //Type: Dragonborn are humanoids with the
        //Dragonborn subtype.
        creature.RaceType = RaceType.Humanoid;
        creature.RaceSubType.Add(RaceSubType.Dragonborn);

        // Languages. You can speak, read, and write
        // Common and Draconic. Draconic is thought
        // to be one of the oldest languages and is
        // often used in the study of magic.
        // The language sounds harsh to most other
        // creatures and includes numerous hard
        // consonants and sibilants.
        creature.Languages.Add(LanguageEnum.Common);
        creature.Languages.Add(LanguageEnum.Draconic);
    }

    //Table: Random Height and Weight
    //Gender Base Height   Height Modifier Base Weight Weight Modifier
    //Male	 6 ft. 2 in.	+2d8 in.        100 lbs.    +(2d8×5 lbs.)
    //Female 6 ft. 0 in.	+2d8 in.         90 lbs.    +(2d8×5 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private static void SetHeightAndWeight(Character creature)
    {
        if (creature?.Gender?.GenderEnum == GenderEnum.Male)
        {
            var modifier = new Dice("2d8").Total;
            if (modifier <= 9)
            {
                creature.Height = $"6 ft. {modifier + 2} in.";
            }
            else if (modifier == 10)
            {
                creature.Height = $"7 ft.";
            }
            else
            {
                creature.Height = $"7 ft. {modifier - 10} in.";
            }
            // 100 lbs. +(2d8×5 lbs.)
            creature.Weight = 200 + (new Dice("2d8").Total * 5);
        }

        if (creature?.Gender?.GenderEnum == GenderEnum.Female)
        {
            var modifier = new Dice("2d8").Total;
            if (modifier <= 11)
            {
                creature.Height = $"5 ft. {modifier} in.";
            }
            else if (modifier == 12)
            {
                creature.Height = $"6 ft.";
            }
            else
            {
                creature.Height = $"6 ft. {modifier - 12} in.";
            }
            // 180 lbs. +(2d8×5 lbs.)
            creature.Weight = 180 + (new Dice("2d8").Total * 5);
        }
    }

    // Table: Random Starting Ages
    // Adulthood   Intuitive1 Self-Taught2 Trained3
    // 15 years	   +1d6 years  +2d6 years  +3d6 years
    /// <summary>
    /// Set the age
    /// </summary>
    /// <param name="creature"></param>
    private static void SetAge(Character creature)
    {
        creature.Age = 15;

        // barbarians, rogues, sorcerers and warlocks.
        if (creature?.CharacterClass?.Class == ClassEnum.Barbarian ||
            creature?.CharacterClass?.Class == ClassEnum.Rogue ||
            creature?.CharacterClass?.Class == ClassEnum.Sorcerer ||
            creature?.CharacterClass?.Class == ClassEnum.Warlock)
        {
            creature.Age += new Dice("1d6").Total;
        }

        // bards, fighters, paladins and rangers.
        if (creature?.CharacterClass?.Class == ClassEnum.Bard ||
            creature?.CharacterClass?.Class == ClassEnum.Fighter ||
            creature?.CharacterClass?.Class == ClassEnum.Paladin ||
            creature?.CharacterClass?.Class == ClassEnum.Ranger)
        {
            creature.Age += new Dice("2d6").Total;
        }

        // clerics, druids, monks, and wizards.
        if (creature?.CharacterClass?.Class == ClassEnum.Cleric ||
            creature?.CharacterClass?.Class == ClassEnum.Druid ||
            creature?.CharacterClass?.Class == ClassEnum.Monk ||
            creature?.CharacterClass?.Class == ClassEnum.Wizard)
        {
            creature.Age += new Dice("3d6").Total;
        }
    }

    /// <summary>
    /// Nothing for Dragonborn
    /// </summary>
    /// <param name="character"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void GenerateRaceBackground(Character character)
    {
        throw new NotImplementedException();
    }
}