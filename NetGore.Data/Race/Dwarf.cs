using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Race;

/// <summary>
/// Dwarves are a stoic but stern race, ensconced 
/// in cities carved from the hearts of mountains 
/// and fiercely determined to repel the depredations 
/// of savage races like orcs and goblins. More than 
/// any other race, dwarves have acquired a 
/// reputation as dour and humorless artisans 
/// of the earth.It could be said that their history 
/// shapes the dark disposition of many dwarves, 
/// for they reside in high mountains and dangerous 
/// realms below the earth, constantly at war with 
/// giants, goblins, and other such horrors.
/// </summary>
public class Dwarf
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature">The playercharacter</param>
    public Dwarf(PlayerCharacter creature)
    {
        creature.RaceName = nameof(Dwarf);
        creature.Description = "Your dwarf character " +
            "has an assortment of inborn abilities, " +
            "part and parcel of dwarven nature.";

        // Your Constitution score increases by 2.
        creature.Constitution.RacialModifier += 2;

        // Size. Dwarves stand between 4 and 5 feet tall
        // and average about 150 pounds. Your size is Medium.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Medium;

        // Speed.Your base walking speed is 25 feet.
        // Your speed is not reduced by wearing
        // heavy armor
        creature.Speed = 25;
    }

    // Table: Random Height and Weight
    // Gender Base Height Height Modifier Base Weight Weight Modifier
    // Male	  3 ft. 9 in.	+2d4 in.	        150 lbs.    +(2d4×7 lbs.)
    // Female 3 ft. 7 in.	+2d4 in.            120 lbs.    +(2d4×7 lbs.)
    /// <summary>
    /// The dwarfs Height
    /// </summary>
    /// <param name="creature">The dwarf</param>
    private static void SetHeightAndWeight(Creature creature)
    {
        if (creature?.Gender?.GenderEnum == GenderEnum.Male)
        {
            var modifier = new Dice("2d4").Total;
            if (modifier <= 2)
            {
                creature.Height = $"3 ft. {modifier + 9} in.";
            }
            else if (modifier == 3) 
            {
                creature.Height = $"4 ft.";
            }
            else
            {
                creature.Height = $"4 ft. {modifier-3} in.";
            }
            // 150 lbs. +(2d4×7 lbs.)
            creature.Weight = 150 + (new Dice("2d4").Total * 7);
        }

        if (creature?.Gender?.GenderEnum == GenderEnum.Female)
        {
            var modifier = new Dice("2d4").Total;
            if (modifier <= 4)
            {
                creature.Height = $"3 ft. {modifier + 7} in.";
            }
            else if (modifier == 5)
            {
                creature.Height = $"4 ft.";
            }
            else
            {
                creature.Height = $"4 ft. {modifier - 5} in.";
            }
            // 120 lbs. +(2d4×7 lbs.)
            creature.Weight = 120 + (new Dice("2d4").Total * 7);
        }
    }

    //Table: Random Starting Ages
    //Adulthood Intuitive1  Self-Taught2 Trained3
    //40 years	+3d6 years
    //(43 – 58 years) +5d6 years
    //(45 – 70 years) +7d6 years
    //(47 – 82 years)
    //1 This category includes barbarians, oracles, rogues, and sorcerers.
    //2 This category includes bards, cavaliers, fighters, gunslingers, paladins, rangers, summoners, and witches.
    //3 This category includes alchemists, clerics, druids, inquisitors, magi, monks, and wizards.
    /// <summary>
    /// Set the age
    /// </summary>
    /// <param name="creature"></param>
    private static void SetAge(PlayerCharacter creature)
    {
        creature.Age = 40;

        // barbarians, rogues, sorcerers and warlocks.
        if (creature?.CharacterClass?.Class == ClassEnum.Barbarian ||
            creature?.CharacterClass?.Class == ClassEnum.Rogue ||
            creature?.CharacterClass?.Class == ClassEnum.Sorcerer ||
            creature?.CharacterClass?.Class == ClassEnum.Warlock)
        {
            creature.Age += new Dice("3d6").Total;
        }

        // bards, fighters, paladins and rangers.
        if (creature?.CharacterClass?.Class == ClassEnum.Bard ||
            creature?.CharacterClass?.Class == ClassEnum.Fighter ||
            creature?.CharacterClass?.Class == ClassEnum.Paladin ||
            creature?.CharacterClass?.Class == ClassEnum.Ranger)
        {
            creature.Age += new Dice("5d6").Total;
        }

        // clerics, druids, monks, and wizards.
        if (creature?.CharacterClass?.Class == ClassEnum.Cleric ||
            creature?.CharacterClass?.Class == ClassEnum.Druid ||
            creature?.CharacterClass?.Class == ClassEnum.Monk ||
            creature?.CharacterClass?.Class == ClassEnum.Wizard)
        {
            creature.Age += new Dice("7d6").Total;
        }
    }
}
