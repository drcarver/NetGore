using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

public class Elf
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Elf(PlayerCharacter creature)
    {
        creature.RaceName = nameof(Elf);
        creature.RaceDescription =
            "Your elf character has a variety " +
            "of natural abilities, the result " +
            "of thousands of years of elven refinement.";

        // Your Dexterity score increases by 2.
        creature.Dexterity.RacialModifier += 2;

        // Size. Elves stand between 4 and 5 feet tall
        // and average about 150 pounds. Your size is Medium.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Medium;

        // Speed.Your base walking speed is 25 feet.
        // Your speed is not reduced by wearing
        // heavy armor
        creature.Speed = 30;
    }

    // Table: Random Height and Weight
    //Gender Base Height Height Modifier Base Weight Weight Modifier
    //Male	 5 ft. 4 in.    +2d8 in.      110 lbs.    +(2d8×3 lbs.)
    //Female 5 ft. 4 in.	+2d6 in.       90 lbs.    +(2d6×3 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The dwarf</param>
    private static void SetHeightAndWeight(Creature creature)
    {
        if (creature?.Gender?.GenderEnum == GenderEnum.Male)
        {
            var modifier = new Dice("2d8").Total;
            if (modifier <= 7)
            {
                creature.Height = $"5 ft. {4 + modifier} in.";
            }
            else if (modifier == 8)
            {
                creature.Height = $"6 ft.";
            }
            else
            {
                creature.Height = $"6 ft. {modifier-9} in.";
            }
            // 110 lbs. +(2d8×3 lbs.)
            creature.Weight = 110 + (new Dice("2d8").Total * 3);
        }

        if (creature?.Gender?.GenderEnum == GenderEnum.Female)
        {
            var modifier = new Dice("2d6").Total;
            if (modifier <= 7)
            {
                creature.Height = $"5 ft. {4 + modifier} in.";
            }
            else if (modifier == 8)
            {
                creature.Height = $"6 ft.";
            }
            else
            {
                creature.Height = $"6 ft. {modifier - 9} in.";
            }
            // 90 lbs. +(2d6×3 lbs.)
            creature.Weight = 90 + (new Dice("2d6").Total * 3);
        }
    }

    // Table: Random Starting Ages
    // Adulthood Intuitive1  Self-Taught2 Trained3
    // 110 years  +4d6 years   +6d6 years +10d6 years
    //1 This category includes barbarians, oracles, rogues, and sorcerers.
    //2 This category includes bards, cavaliers, fighters, gunslingers, paladins, rangers, summoners, and witches.
    //3 This category includes alchemists, clerics, druids, inquisitors, magi, monks, and wizards.
    /// <summary>
    /// Set the age
    /// </summary>
    /// <param name="creature"></param>
    private static void SetAge(PlayerCharacter creature)
    {
        creature.Age = 110;

        // barbarians, rogues, sorcerers and warlocks.
        if (creature?.CharacterClass?.Class == ClassEnum.Barbarian ||
            creature?.CharacterClass?.Class == ClassEnum.Rogue ||
            creature?.CharacterClass?.Class == ClassEnum.Sorcerer ||
            creature?.CharacterClass?.Class == ClassEnum.Warlock)
        {
            creature.Age += new Dice("4d6").Total;
        }

        // bards, fighters, paladins and rangers.
        if (creature?.CharacterClass?.Class == ClassEnum.Bard ||
            creature?.CharacterClass?.Class == ClassEnum.Fighter ||
            creature?.CharacterClass?.Class == ClassEnum.Paladin ||
            creature?.CharacterClass?.Class == ClassEnum.Ranger)
        {
            creature.Age += new Dice("6d6").Total;
        }

        // clerics, druids, monks, and wizards.
        if (creature?.CharacterClass?.Class == ClassEnum.Cleric ||
            creature?.CharacterClass?.Class == ClassEnum.Druid ||
            creature?.CharacterClass?.Class == ClassEnum.Monk ||
            creature?.CharacterClass?.Class == ClassEnum.Wizard)
        {
            creature.Age += new Dice("10d6").Total;
        }
}