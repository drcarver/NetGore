using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Background;
using NetGore.Data.Services;

namespace NetGore.Data.Race;

/// <summary>
/// Elves are often raised in insular elven 
/// communities, and the longevity of these 
/// people means that elven children often 
/// grow up with the help of a large social 
/// network.
/// </summary>
public class Elf : IRace
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Elf(Character creature)
    {
        Initialize(creature);
    }

    /// <summary>
    /// Initialize the character
    /// </summary>
    /// <param name="creature"></param>
    public void Initialize(Character creature)
    {
        creature.RaceName = nameof(Elf);
        creature.RaceDescription =
        "Your elf character has a variety " +
        "of natural abilities, the result " +
        "of thousands of years of elven refinement.";

        //Ability Score Increase.Your Dexterity
        //score increases by 2.creature.
        creature.Dexterity.RacialModifier = 2;

        //Size: Elves are Medium creatures and thus
        //receive no bonuses or penalties due to
        //their size.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Medium;

        //Base Speed: Elves have a base speed of
        //30 feet.
        creature.Speed = 30;

        //Type: Elves are Humanoids with the elf
        //subtype.
        creature.RaceType = RaceType.Humanoid;
        creature.RaceSubType.Add(RaceSubType.Elf);

        //Languages: Elves begin play speaking Common
        //and Elven .Elves with high Intelligence
        //scores can choose from the following:
        //Celestial, Draconic, Gnoll, Gnome, Goblin,
        //Orc, and Sylvan. See the Linguistics skill
        //page for more information about these
        //languages.
        creature.Languages.Add(LanguageEnum.Common);
        creature.Languages.Add(LanguageEnum.Elven);

    }

    //Table: Elf Homeland
    //d%	Result
    //01–60	Forest You gain access to the Log Roller regional trait.
    //61–80	Non-Elven City or Metropolis    If you’re an elf, you gain access to the Civilized social trait and the Forlorn race trait.If you’re a half-elf, you gain access to the Civilized social trait and the Failed Apprentice race trait.
    //81–95	Non-Elven Town or Village   If you’re an elf, you gain access to the Forlorn race trait. If you’re a half-elf, you gain access to the Failed Apprentice race trait.
    //96–100	Unusual Homeland.	Roll on Table: Unusual Homeland. If you’re an elf, you gain access to the Forlorn trait.If you’re a half-elf, you gain access to the Elven Reflexes race trait.
    /// <summary>
    /// The homeland table
    /// </summary>
    public static RandomTable HomelandTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Forest"
            //01–60	Forest You gain access to the
            //Log Roller regional trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 60,
                Name = "Forest",
                Description =
                    "You gain access to the " +
                    "Log Roller regional trait.",
                Traits =
                {
                    TraitEnum.LogRoller,
                },
            },
            #endregion

            #region "Non-Elven City or Metropolis"
            //61–80	Non-Elven City or Metropolis    
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 80,
                Name = "Non-Elven City or Metropolis",
                Description =
                    "If you’re an elf, you gain access " +
                    "to the Civilized social trait and " +
                    "the Forlorn race trait.If you’re " +
                    "a half-elf, you gain access to the " +
                    "Civilized social trait and the " +
                    "Failed Apprentice race trait.",
                Traits =
                {
                    TraitEnum.Civilized
                },

            },
            #endregion

            #region "Non-Elven Town or Village"
            //81–95	Non-Elven Town or Village
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 95,
                Name = "Non-Dwarven Town or Village",
                Description =
                    "You gain access to the Forlorn race trait.",
                Traits =
                {
                    TraitEnum.Forlorn,
                },
            },
            #endregion
                        
            #region "Unusual Homeland."
            //96–100	Unusual Homeland.
            new RandomTableEntry
            {
                LowerRange = 96,
                UpperRange = 100,
                Name = "Unusual Homeland",
                AlternateTable = BackgroundTables.UnusualHomelandTable,
            },
            #endregion
        ],
    };

    //Table: Elf Parents
    //d%	Result
    //01–79	Both of your parents are alive.
    //80–87	Only your father is alive.
    //88–95	Only your mother is alive.
    //96–100	Both of your parents are dead. You gain access to the Orphaned social trait
    /// <summary>
    /// The parents table
    /// </summary>
    private static RandomTable ParentsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Both"
            //01–79	Both of your parents are alive.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 79,
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //80–87	Only your father is alive.
            new RandomTableEntry
            {
                LowerRange = 80,
                UpperRange = 87,
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //88–95	Only your mother is alive.
            new RandomTableEntry
            {
                LowerRange = 88,
                UpperRange = 95,
                Name = "Mother Only",
                Description = "Only your mother is alive.",
            },
            #endregion

            #region "Both Dead"
            //96–100 Both of your parents are dead.
            //You gain access to the Orphaned social
            //trait.    
            new RandomTableEntry
            {
                LowerRange = 96,
                UpperRange = 100,
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

    //Table: Elf Siblings
    //d%	Result
    //01–80	1d2 biological siblings.If you roll 2 siblings, you gain access to the Kin Guardian combat trait.
    //81–85	1d4+1 biological siblings. You gain access to the Kin Guardian combat trait.
    //86–90	1d4+1 biological siblings. 1d3–1 of these siblings are half-elves, adopted, or a mix of the two (your choice). You gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
    //91–100	No siblings.
    /// <summary>
    /// The siblings table
    /// </summary>
    private static RandomTable SiblingsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "1d2"
            //01–80	1d2 biological siblings.If you roll 2 siblings, you gain access to the Kin Guardian combat trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 80,
                Name = "1d2",
                Description =
                    "With two or more siblings, you gain access " +
                    "to the Kin Guardian combat trait.",
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d4+1"
            //81–85	1d4+1 biological siblings. You gain access to the Kin Guardian combat trait.
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 85,
                Name = "1d4+1",
                Description =
                    "You gain access to " +
                    "the Kin Guardian combat trait.",
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d4+1 "
            //86–90	1d4+1 biological siblings. 1d3–1 of these siblings are half-elves, adopted, or a mix of the two (your choice). You gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
            new RandomTableEntry
            {
                LowerRange = 86,
                UpperRange = 90,
                Name = "1d3",
                Description = "1d4+1 biological " +
                    "siblings. 1d3–1 of these siblings " +
                    "are half-elves, adopted, or a mix " +
                    "of the two (your choice). You gain " +
                    "access to the Kin Guardian combat " +
                    "trait. Roll on Table: " +
                    "Race Table to determine the " +
                    "race of any adopted siblings.",
                AlternateTable = RaceService.RaceTable,
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "No siblings"
            //91–100 No siblings    
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 100,
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
        var homeland = (RandomTableEntry?)HomelandTable.GetRandomEntry();
        if (homeland?.Name == "Unusual Homeland")
        {
            homeland = (RandomTableEntry?)BackgroundTables.UnusualHomelandTable.GetRandomEntry();
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
        var parents = (RandomTableEntry?)ParentsTable.GetRandomEntry();
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
        var siblings = (RandomTableEntry?)SiblingsTable.GetRandomEntry();
        if (siblings?.Name != "No siblings" && !string.IsNullOrEmpty(siblings?.Name))
        {
            var total = new Dice(siblings.Name).Total;
            for (int i = 0; i < total; i++)
            {
                var creaturesiblings = new Character();
                Initialize(creaturesiblings);

                // Set relative age of sibling
                var relativeage = BackgroundTables.RelativeAgeofSiblingTable.GetRandomEntry();
                if (relativeage?.Name == "Younger")
                {
                    creaturesiblings.Age -= new Dice("1d4").Total;
                }
                if (relativeage?.Name == "Older")
                {
                    creaturesiblings.Age += new Dice("1d4").Total;
                }

                character.Siblings.Add(creaturesiblings);
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
    private static void SetAge(Character creature)
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
}