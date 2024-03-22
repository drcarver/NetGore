using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

public class Human
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Human(PlayerCharacter creature)
    {
        creature.RaceName = nameof(Human);
        creature.RaceDescription =
            "It’s hard to make generalizations " +
            "about humans, but your human " +
            "character has these traits.";

        // Your score increase by 1.
        creature.Strength.RacialModifier += 1;
        creature.Intelligence.RacialModifier += 1;
        creature.Wisdom.RacialModifier += 1;
        creature.Dexterity.RacialModifier += 1;
        creature.Constitution.RacialModifier += 1;
        creature.Charisma.RacialModifier += 1;

        // Size. Your size is Medium.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Medium;

        // Speed.Your base walking speed is 25 feet.
        // Your speed is not reduced by wearing
        // heavy armor
        creature.Speed = 30;
    }

    //Table: Random Height and Weight
    //Gender Base Height        Height Modifier Base Weight Weight Modifier
    //Male	    4 ft. 10 in.	+2d10 in.       120 lbs.    +(2d10×5 lbs.)
    //Female	4 ft. 5 in.	    +2d10 in.        85 lbs. +(2d10×5 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private static void SetHeightAndWeight(PlayerCharacter creature)
    {
        if (creature?.Gender?.GenderEnum == GenderEnum.Male)
        {
            var modifier = new Dice("2d10").Total;
            if (modifier <= 1)
            {
                creature.Height = $"4 ft. {modifier + 10} in.";
            }
            else if (modifier == 2)
            {
                creature.Height = $"5 ft.";
            }
            else if (modifier <= 13 && modifier >= 3)
            {
                creature.Height = $"5 ft. {modifier - 2} in.";
            }
            else
            {
                creature.Height = $"6 ft. {modifier - 13} in.";
            }
            // 120 lbs.    +(2d10×5 lbs.)
            creature.Weight = 120 + (new Dice("2d10").Total * 5);
        }

        if (creature?.Gender?.GenderEnum == GenderEnum.Female)
        {
            var modifier = new Dice("2d10").Total;
            if (modifier <= 6)
            {
                creature.Height = $"4 ft. {modifier+5} in.";
            }
            else if (modifier == 7)
            {
                creature.Height = $"5 ft.";
            }
            else if (modifier <= 19 && modifier >= 8)
            {
                creature.Height = $"5 ft. {modifier - 8} in.";
            }
            else
            {
                creature.Height = $"6 ft.";
            }
            // 85 lbs. +(2d10×5 lbs.)
            creature.Weight = 85 + (new Dice("2d10").Total * 5);
        }
    }

    //Table: Random Starting Ages
    //Adulthood   Intuitive1    Self-Taught2 Trained3
    //15 years	    +1d4 years  +1d6 years   +2d6 years
    //1 This category includes barbarians, oracles, rogues, and sorcerers.
    //2 This category includes bards, cavaliers, fighters, gunslingers, paladins, rangers, summoners, and witches.
    //3 This category includes alchemists, clerics, druids, inquisitors, magi, monks, and wizards.    
    /// <summary>
    /// Set the age
    /// </summary>
    /// <param name="creature"></param>
    private static void SetAge(PlayerCharacter creature)
    {
        creature.Age = 15;

        // barbarians, rogues, sorcerers and warlocks.
        if (creature?.CharacterClass?.Class == ClassEnum.Barbarian ||
            creature?.CharacterClass?.Class == ClassEnum.Rogue ||
            creature?.CharacterClass?.Class == ClassEnum.Sorcerer ||
            creature?.CharacterClass?.Class == ClassEnum.Warlock)
        {
            creature.Age += new Dice("1d4").Total;
        }

        // bards, fighters, paladins and rangers.
        if (creature?.CharacterClass?.Class == ClassEnum.Bard ||
            creature?.CharacterClass?.Class == ClassEnum.Fighter ||
            creature?.CharacterClass?.Class == ClassEnum.Paladin ||
            creature?.CharacterClass?.Class == ClassEnum.Ranger)
        {
            creature.Age += new Dice("1d6").Total;
        }

        // clerics, druids, monks, and wizards.
        if (creature?.CharacterClass?.Class == ClassEnum.Cleric ||
            creature?.CharacterClass?.Class == ClassEnum.Druid ||
            creature?.CharacterClass?.Class == ClassEnum.Monk ||
            creature?.CharacterClass?.Class == ClassEnum.Wizard)
        {
            creature.Age += new Dice("2d6").Total;
        }
    }
}