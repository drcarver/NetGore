using System.Diagnostics.CodeAnalysis;

using D20.Background.Enum;
using D20.Background.Models;
using D20.Character.Interfaces;
using D20.Core;
using D20.Core.Enum;
using D20.Core.Models;
using D20.Monsters.Interfaces;
using D20.Monsters.Models;

using Microsoft.Extensions.Logging;

namespace D20.Race;

/// <summary>
/// The capricious and carefree gnomes of the world 
/// are widespread and varied. They typically either 
/// form their own gnome communities or integrate 
/// themselves into other humanoid societies.
/// </summary>
public class HalfElf : CharacterRace, ICharacterRace
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    [SetsRequiredMembers]
    public HalfElf(ILoggerFactory loggerFactory)
        : base(loggerFactory)
    {
        Initialize();
    }

    /// <summary>
    /// Initialize the creature
    /// </summary>
    public void Initialize()
    {
        Race = RaceEnum.HalfElf;

        //Ability Score Increase. Your Charisma
        //score increases by 2, and two other
        //ability scores of your choice increase
        //by 1.
        Charisma.RacialModifier += 2;
        Intelligence.RacialModifier += 1;
        Dexterity.RacialModifier += 1;

        // Size. Elves stand between 4 and 5 feet tall
        // and average about 150 pounds. Your size is Medium.
        SetHeightAndWeight();
        Size = SizeEnum.Medium;

        // Speed.Your base walking speed is 25 feet.
        // Your speed is not reduced by wearing
        // heavy armor
        Speed = 30;
    }

    //Table: Half-Elf Homeland
    //d%	Result
    //01–25	Raised in an Elven Homeland.Roll on Table: Elf Homeland.
    //26–75	Raised in a Human Homeland.Roll on Table: Human Homeland.
    //76–95	Forest You gain access to the Log Roller regional trait.
    //96–100	Unusual Homeland.	Roll on Table: Unusual Homeland.
    /// <summary>
    /// The homeland table
    /// </summary>
    private static RandomTable HomelandTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Raised in an Elven Homeland."
            //01–25	Raised in an Elven Homeland. Roll
            //on Table: Elf Homeland.
            new BackgroundTableEntry
            {
                Range = new Range(01,25),
                Name = "Raised in an Elven Homeland",
                Description =
                    "Raised in an Elven Homeland. " +
                    "Roll on Table: Elf Homeland.",
                //AlternateTable = Elf.HomelandTable
            },
            #endregion

            #region "Raised in a Human Homeland"
            //26–75	Raised in a Human Homeland.Roll on Table: Human Homeland.
            new BackgroundTableEntry
            {
                Range = new Range(26,75),
                Name = "Raised in a Human Homeland",
                Description =
                    "Raised in a Human Homeland. Roll on Table: Human Homeland.",
                //AlternateTable = Human.HomelandTable
            },
            #endregion

            #region "Forest"
            //76–95	Forest You gain access to the Log
            //Roller regional trait.
            new BackgroundTableEntry
            {
                Range = new Range(76,95),
                Name = "Forest",
                Description =
                    "You gain access to the Log Roller regional trait.",
                Traits =
                {
                },
            },
            #endregion
                        
            #region "Unusual Homeland."
            //96–100 Unusual Homeland.	Roll on Table:
            //Unusual Homeland.
            new BackgroundTableEntry
            {
                Range = new Range(96,100),
                Name = "Unusual Homeland",
            },
            #endregion
        ],
    };

    //Table: Half-Elf Parents
    //d%	Result
    //01–20	Both of your parents are alive.
    //21–55	Only your father is alive.
    //56–90	Only your mother is alive.
    //91–100 Both of your parents are dead. You gain access to the Orphaned social trait.
    /// <summary>
    /// The parents table
    /// </summary>
    private static RandomTable ParentsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Both"
            //01–20	Both of your parents are alive.
            new BackgroundTableEntry
            {
                Range = new Range(01,20),
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //21–55	Only your father is alive.
            new BackgroundTableEntry
            {
                Range = new Range(21,55),
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //56–90	Only your mother is alive.
            new BackgroundTableEntry
            {
                Range = new Range(56,90),
                Name = "Mother Only",
                Description = "Only your mother is alive.",
            },
            #endregion

            #region "Both Dead"
            //91–100 Both of your parents are dead.
            //You gain access to the Orphaned social
            //trait.
            new BackgroundTableEntry
            {
                Range = new Range(91,100),
                Name = "Both Dead",
                Description =
                    "Both of your parents are dead. " +
                    "You gain access to the Orphaned " +
                    "social trait.",
                Traits =
                {
                    TraitEnum.Orphaned,
                },
            },
            #endregion
        ],
    };

    //Table: Half-Elf Siblings
    //d%	Result
    //01–20	1d2 half-siblings(either elf or human, your choice). With two or more siblings, you gain access to the Kin Guardian combat trait.
    //21–30	One half-elf sibling.You gain access to the Kin Bond magic trait.
    //31–100	No siblings.
    /// <summary>
    /// The siblings table
    /// </summary>
    private static RandomTable SiblingsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "1d2"
            //01–20	1d2 half-siblings(either elf or
            //human, your choice). With two or more
            //siblings, you gain access to the Kin
            //Guardian combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(01,50),
                Name = "1d2",
                Description =
                    "1d2 half-siblings(either elf or " +
                    "human, your choice). With two " +
                    "or more siblings, you gain access " +
                    "to the Kin Guardian combat trait.",
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d1"
            //21–30	One half-elf sibling.You gain access to the Kin Bond magic trait.
            new BackgroundTableEntry
            {
                Range = new Range(21,30),
                Name = "1d1",
                Description =
                    "One half-elf sibling. You gain " +
                    "access to the Kin Bond magic " +
                    "trait.",
                Traits =
                {
                    TraitEnum.KinBond,
                },
            },
            #endregion

            #region "No siblings"
            //31–100	No siblings.
            new BackgroundTableEntry
            {
                Range = new Range(31,100),
                Name = "No siblings",
                Description = "No siblings",
            },
            #endregion
        ],
    };

    //Table: Random Height and Weight
    //Gender Base Height   Height Modifier Base Weight Weight Modifier
    //Male	 5 ft. 2 in.	+2d8 in.        100 lbs.    +(2d8×5 lbs.)
    //Female 5 ft. 0 in.	+2d8 in.         90 lbs.    +(2d8×5 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private static void SetHeightAndWeight(ICharacter creature)
    {
        if (creature?.Gender == GenderEnum.Male)
        {
            var modifier = new Dice("2d8").Total;
            if (modifier <= 9)
            {
                //creature.Height = $"5 ft. {modifier + 2} in.";
            }
            else if (modifier == 10)
            {
                //creature.Height = $"6 ft.";
            }
            else
            {
                //creature.Height = $"6 ft. {modifier - 10} in.";
            }
            // 100 lbs. +(2d8×5 lbs.)
            creature.Weight = 100 + new Dice("2d8").Total * 5;
        }

        if (creature?.Gender == GenderEnum.Female)
        {
            var modifier = new Dice("2d8").Total;
            if (modifier <= 11)
            {
                //creature.Height = $"5 ft. {modifier} in.";
            }
            else if (modifier == 12)
            {
                //creature.Height = $"6 ft.";
            }
            else
            {
                //creature.Height = $"6 ft. {modifier - 12} in.";
            }
            // 90 lbs. +(2d8×5 lbs.)
            creature.Weight = 90 + new Dice("2d8").Total * 5;
        }
    }
}