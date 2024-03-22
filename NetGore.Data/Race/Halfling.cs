using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

public class Hafling
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Hafling(PlayerCharacter creature)
    {
        creature.RaceName = nameof(Hafling);
        creature.RaceDescription =
            "Your halfling character has a " +
            "number of traits in common " +
            "with all other halflings.";

        // Your Dexterity score increases by 2.
        creature.Dexterity.RacialModifier += 2;

        // Size. Your size is Medium.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Small;

        // Speed.Your base walking speed is 25 feet.
        // Your speed is not reduced by wearing
        // heavy armor
        creature.Speed = 25;
    }

    //Table: Random Height and Weight
    //Gender Base Height    Height Modifier Base Weight Weight Modifier
    //Male	    2 ft. 8 in.	 +2d4 in.        30 lbs. +(2d4 lbs.)
    //Female	2 ft. 6 in.	 +2d4 in.        25 lbs. +(2d4 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private static void SetHeightAndWeight(PlayerCharacter creature)
    {
        if (creature?.Gender?.GenderEnum == GenderEnum.Male)
        {
            var modifier = new Dice("2d4").Total;
            if (modifier <= 3)
            {
                creature.Height = $"2 ft. {modifier + 8} in.";
            }
            else if (modifier == 4)
            {
                creature.Height = $"3 ft.";
            }
            else
            {
                creature.Height = $"3 ft. {modifier - 4} in.";
            }
            // 30 lbs. +(2d4 lbs.)
            creature.Weight = 30 + new Dice("2d4").Total;
        }

        if (creature?.Gender?.GenderEnum == GenderEnum.Female)
        {
            var modifier = new Dice("2d4").Total;
            if (modifier <= 5)
            {
                creature.Height = $"2 ft. {modifier} in.";
            }
            else if (modifier == 6)
            {
                creature.Height = $"3 ft.";
            }
            else
            {
                creature.Height = $"3 ft. {modifier - 6} in.";
            }
            // 25 lbs. +(2d4 lbs.)
            creature.Weight = 25 + new Dice("2d4").Total;
        }
    }

    //Table: Random Starting Ages
    //Adulthood   Intuitive1 Self-Taught2 Trained3
    //20 years	 +2d4 years   +3d6 years   +4d6 years
    //1 This category includes barbarians, oracles, rogues, and sorcerers.
    //2 This category includes bards, cavaliers, fighters, gunslingers, paladins, rangers, summoners, and witches.
    //3 This category includes alchemists, clerics, druids, inquisitors, magi, monks, and wizards.
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
            creature.Age += new Dice("2d4").Total;
        }

        // bards, fighters, paladins and rangers.
        if (creature?.CharacterClass?.Class == ClassEnum.Bard ||
            creature?.CharacterClass?.Class == ClassEnum.Fighter ||
            creature?.CharacterClass?.Class == ClassEnum.Paladin ||
            creature?.CharacterClass?.Class == ClassEnum.Ranger)
        {
            creature.Age += new Dice("3d6").Total;
        }

        // clerics, druids, monks, and wizards.
        if (creature?.CharacterClass?.Class == ClassEnum.Cleric ||
            creature?.CharacterClass?.Class == ClassEnum.Druid ||
            creature?.CharacterClass?.Class == ClassEnum.Monk ||
            creature?.CharacterClass?.Class == ClassEnum.Wizard)
        {
            creature.Age += new Dice("4d6").Total;
        }
    }
}