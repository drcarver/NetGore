using System.Net.Sockets;

using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Background;
using NetGore.Data.Classes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

using static Microsoft.Maui.ApplicationModel.Permissions;

using static System.Formats.Asn1.AsnWriter;
using NetGore.Data.Models;
using NetGore.Data.Interfaces;

namespace NetGore.Data.Race;

/// <summary>
/// As diverse as they are widespread, humans tend to grow up in small or large societies of people with similar origins and histories, though individuals’ paths may run the gamut from idealized to tragic.
/// </summary>
public class Human : IRace
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Human(Character creature)
    {
        Initialize(creature);
    }

    /// <summary>
    /// Initialize the creature
    /// </summary>
    /// <param name="creature"></param>
    public void Initialize(Character creature)
    {
        creature.Race = RaceEnum.Human;

        //Ability Score Modifiers: Human characters
        //gain a +1 racial bonus to every ability
        //score at creation to represent their
        //varied nature.
        creature.Strength.RacialModifier += 1;
        creature.Intelligence.RacialModifier += 1;
        creature.Wisdom.RacialModifier += 1;
        creature.Dexterity.RacialModifier += 1;
        creature.Constitution.RacialModifier += 1;
        creature.Charisma.RacialModifier += 1;

        //Size: Humans are Medium creatures and
        //thus receive no bonuses or penalties
        //due to their size.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Medium;

        //Base Speed: Humans have a base speed of 30
        //feet.
        creature.Speed = 30;

        //Type: Humans are humanoids with the
        //human subtype.
        creature.RaceType = RaceType.Humanoid;
        creature.RaceSubType.Add(RaceSubType.Human);

        //Languages: Humans begin play speaking
        //Common. 
        creature.Languages.Add(LanguageEnum.Common);
    }

    //Table: Human Homeland
    //d%	Result
    //01–50	Town or Village You gain access to the Militia Veteran regional trait.
    //51–85	City or Metropolis If you’re a human, you gain access to the Civilized social trait and the Vagabond Child regional trait. If you’re a half-elf, you gain access to the Civilized social trait and the Failed Apprentice race trait. If you’re a half-orc, you gain access to the Brute race trait and the Vagabond Child regional trait.
    //86–95	Frontier You gain access to the Frontier-Forged regional trait.
    //96–100 Unusual Homeland.	Roll on Table: Unusual Homeland.
    /// <summary>
    /// The homeland table
    /// </summary>
    public static GameTable HomelandTable { get; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Town or Village"
            //01–50	Town or Village You gain access
            //to the Militia Veteran regional trait.
            new BackgroundTableEntry
            {
                Range = new Range(01,50),
                Name = "Town or Village",
                Description =
                "You gain access to the Militia Veteran regional trait.",
                Traits =
                {
                    TraitEnum.MilitiaVeteran,
                },
            },
            #endregion

            #region "City or Metropolis"
            //51–85	City or Metropolis If you’re a
            //human, you gain access to the Civilized
            //social trait and the Vagabond Child
            //regional trait.
            new BackgroundTableEntry
            {
                Range = new Range(51,85),
                Name = "City or Metropolis",
                Description = "If you’re a human, you gain access to the Civilized social trait and the Vagabond Child regional trait",
                Traits =
                {
                    TraitEnum.Civilized,
                    TraitEnum.VagabondChild,
                },
            },
            #endregion

            #region "Frontier"
            //86–95	Frontier You gain access to the Frontier-Forged regional trait.
            new BackgroundTableEntry
            {
                Range = new Range(86,95),
                Name = "Frontier",
                Description = "You gain access to the Frontier-Forged regional trait.",
                Traits =
                {
                    TraitEnum.FrontierForged,
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
                AlternateTable = typeof(IUnusualHomelandTable),
            },
            #endregion
        ],
    };

    //Table: Human Parents
    //d%	Result
    //01–50	Both of your parents are alive.
    //51–70	Only your father is alive.
    //71–90	Only your mother is alive.
    //91–100	Both of your parents are dead. You gain access to the Orphaned social trait.
    /// <summary>
    /// The parents table
    /// </summary>
    private static GameTable ParentsTable { get; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Both"
            //01–50	Both of your parents are alive.
            new BackgroundTableEntry
            {
                Range = new Range(01,50),
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //51–70	Only your father is alive.
            new BackgroundTableEntry
            {
                Range = new Range(51,70),
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //71–90	Only your mother is alive.
            new BackgroundTableEntry
            {
                Range = new Range(71,90),
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

    //Table: Human Siblings
    //d%	Result
    //01–40	1d2 siblings.With two siblings, you gain access to the Kin Guardian combat trait.
    //41–70	1d2 siblings and 1d2 half-siblings(roll d% to determine each one’s race; 01–50: half-elf, 51–100: half-orc). You gain access to the Kin Guardian combat trait.
    //71–90	2d4 siblings.You gain access to the Kin Guardian combat trait.
    //91–100	No siblings.
    /// <summary>
    /// The siblings table
    /// </summary>
    private static GameTable SiblingsTable { get; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "1d2"
            //01–40	1d2 siblings.With two siblings, you gain access to the Kin Guardian combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(01,40),
                Name = "1d4",
                Description =
                    "With two or more siblings, you " +
                    "gain access to the Kin Guardian " +
                    "combat trait.",
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d4"
            //41–70	1d2 siblings and 1d2 half-siblings(roll d% to determine each one’s race)
            new BackgroundTableEntry
            {
                Range = new Range(41,70),
                Name = "1d4",
                Description =
                    "1d2 siblings and 1d2 " +
                    "half-siblings (roll d% to " +
                    "determine each one’s race)",
            },
            #endregion

            #region "2d4"
            //71–90	2d4 siblings.You gain access to the Kin Guardian combat trait.
            new BackgroundTableEntry
            {
                Range = new Range(71,90),
                Name = "2d4",
                Description =
                    "2d4 siblings.You gain access to " +
                    "the Kin Guardian combat trait.",
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "No siblings"
            //91–100	No siblings.
            new BackgroundTableEntry
            {
                Range = new Range(91,100),
                Name = "No siblings",
                Description = "No siblings",
            },
            #endregion
        ],
    };

    /// <summary>
    /// Generate the character background
    /// </summary>
    public void GenerateRaceBackground(Character character)
    {
        #region Homeland
        var homeland = (BackgroundTableEntry?)HomelandTable.GetRandomEntry();
        if (homeland?.Name == "Unusual Homeland")
        {
            //homeland = (BackgroundTableEntry?)BackgroundTables.UnusualHomelandTable.GetRandomEntry();
        }
        character.Homeland = homeland?.Name;
        if (homeland?.Traits != null)
        {
            foreach (var trait in homeland.Traits)
            {
                if (!character.RacialTraits.Contains(trait))
                {
                    character.RacialTraits.Add(trait);
                }
            }
        }
        #endregion

        #region Parents
        var parents = (BackgroundTableEntry?)ParentsTable.GetRandomEntry();
        character.Parents = parents?.Description;
        if (parents?.Traits != null)
        {
            foreach (var trait in parents.Traits)
            {
                if (!character.RacialTraits.Contains(trait))
                {
                    character.RacialTraits.Add(trait);
                }
            }
        }
        #endregion

        #region Siblings
        var siblings = (BackgroundTableEntry?)SiblingsTable.GetRandomEntry();
        if (siblings?.Name != "No siblings" && !string.IsNullOrEmpty(siblings?.Name))
        {
            var total = new Dice(siblings.Name).Total;
            for (int i = 0; i < total; i++)
            {
                //var creaturesiblings = new Character(loggerFactory, classService);
                //Initialize(creaturesiblings);
                //character.Siblings.Add(creaturesiblings);
            }
            if (character.Siblings.Count > 0)
            {
                if (!character.RacialTraits.Contains(TraitEnum.KinGuardian))
                {
                    character.RacialTraits.Add(TraitEnum.KinGuardian);
                }
            }
        }
        #endregion
    }

    //Table: Random Height and Weight
    //Gender Base Height        Height Modifier Base Weight Weight Modifier
    //Male	    4 ft. 10 in.	+2d10 in.       120 lbs.    +(2d10×5 lbs.)
    //Female	4 ft. 5 in.	    +2d10 in.        85 lbs. +(2d10×5 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private static void SetHeightAndWeight(Character creature)
    {
        if (creature?.GenderEnum == GenderEnum.Male)
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

        if (creature?.GenderEnum == GenderEnum.Female)
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
    private static void SetAge(Character creature)
    {
    }
}