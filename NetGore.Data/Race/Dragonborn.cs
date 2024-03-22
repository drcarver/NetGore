using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

public class Dragonborn
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Dragonborn(PlayerCharacter creature)
    {
        creature.RaceName = nameof(Dragonborn);
        creature.RaceDescription =
            "Your draconic heritage manifests in " +
            "a variety of traits you share with " +
            "other dragonborn.";

        // Your Constitution score increases by 2.
        creature.Constitution.RacialModifier += 2;

        // Size. Elves stand between 4 and 5 feet tall
        // and average about 150 pounds. Your size is Medium.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Small;

        // Speed.Your base walking speed is 25 feet.
        // Your speed is not reduced by wearing
        // heavy armor
        creature.Speed = 25;
    }


    //Table: Random Height and Weight
    //Gender Base Height   Height Modifier Base Weight Weight Modifier
    //Male	 5 ft. 2 in.	+2d8 in.        100 lbs.    +(2d8×5 lbs.)
    //Female 5 ft. 0 in.	+2d8 in.         90 lbs.    +(2d8×5 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private static void SetHeightAndWeight(PlayerCharacter creature)
    {
        if (creature?.Gender?.GenderEnum == GenderEnum.Male)
        {
            var modifier = new Dice("2d8").Total;
            if (modifier <= 9)
            {
                creature.Height = $"5 ft. {modifier + 2} in.";
            }
            else if (modifier == 10)
            {
                creature.Height = $"6 ft.";
            }
            else
            {
                creature.Height = $"6 ft. {modifier - 10} in.";
            }
            // 100 lbs. +(2d8×5 lbs.)
            creature.Weight = 100 + (new Dice("2d8").Total * 5);
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
            // 90 lbs. +(2d8×5 lbs.)
            creature.Weight = 90 + (new Dice("2d8").Total * 5);
        }
    }

    // Table: Random Starting Ages
    // Adulthood   Intuitive1 Self-Taught2 Trained3
    // 20 years	   +1d6 years  +2d6 years  +3d6 years
    /// <summary>
    /// Set the age
    /// </summary>
    /// <param name="creature"></param>
    private static void SetAge(PlayerCharacter creature)
    {
        creature.Age = 20;

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
}