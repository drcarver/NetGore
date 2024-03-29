using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Background;

namespace NetGore.Data.Race;

/// <summary>
/// Only rarely the result of a happy union between 
/// the humans and orcs that bring them into the 
/// world, half-orcs are often regarded as monsters. 
/// This bleak reality makes those rare half-orcs, 
/// cherished as much as the young of any other race, 
/// even more extraordinary.
/// </summary>
public class HalfOrc : IRace
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public HalfOrc(Character creature)
    {
        Initialize(creature);
    }

    /// <summary>
    /// Initialize the creature
    /// </summary>
    /// <param name="creature"></param>
    public void Initialize(Character creature)
    {
        creature.RaceName = nameof(HalfOrc);
        creature.RaceDescription =
            "Your half-­orc character has certain " +
            "traits deriving from your orc ancestry.";

        //Ability Score Modifiers: Half - orc
        //characters gain a + 2 bonus to Strength
        //and +1 bonus to constitution
        creature.Strength.RacialModifier = 2;
        creature.Constitution.RacialModifier = 1;

        //Size: Half - orcs are Medium creatures
        //and thus have no bonuses or penalties due
        //to their size.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Medium;

        //Base Speed: Half - orcs have a base
        //speed of 30 feet.
        creature.Speed = 30;

        //Type: Half - orcs are Humanoid creatures
        //with both the human and orc subtypes.
        creature.RaceType = RaceType.Humanoid;
        creature.RaceSubType.Add(RaceSubType.Human);
        creature.RaceSubType.Add(RaceSubType.Orc);

        //Languages: Half - orcs begin play speaking
        //Common and Orc. Half - orcs with high
        //Intelligence scores can choose from the
        //following: Abyssal, Draconic, Giant, Gnoll,
        //and Goblin.
        creature.Languages.Add(LanguageEnum.Common);
        creature.Languages.Add(LanguageEnum.Orc);
    }

    //Table: Half-Orc Homeland
    //d%	Result
    //01–25	Subterranean You gain access to either the Scrapper race trait or the Surface Stranger regional trait.
    //26–60	Orc Settlement  You gain access to the Scrapper race trait.
    //61–75	Raised in a Human Homeland.Roll on Table: Human Homeland.
    //76–90	No True Homeland You have lived a life on the run and gain access to the Outcast race trait.
    //91–100	Unusual Homeland.	Roll on Table: Unusual Homeland.
    /// <summary>
    /// The homeland table
    /// </summary>
    private static RandomTable HomelandTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Subterranean"
            //01–25	Subterranean You gain access to
            //either the Scrapper race trait or the
            //Surface Stranger regional trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 25,
                Name = "Subterranean",
                Description =
                    "You gain access to either the " +
                    "Scrapper race trait or the " +
                    "Surface Stranger regional trait.",
                Traits =
                {
                    TraitEnum.Scrapper,
                    TraitEnum.SurfaceStranger,
                },
            },
            #endregion

            #region Raised in a Human Homeland
            // 61–75	Raised in a Human Homeland.	Roll on Table: Human Homeland.
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 75,
                Name = "Raised in a Human Homeland",
                Description = "Roll on Table: Human Homeland",
                AlternateTable = Human.HomelandTable
            },
            #endregion

            #region "Orc Settlement"
            //26–60	Orc Settlement  You gain access to the Scrapper race trait.
            new RandomTableEntry
            {
                LowerRange = 26,
                UpperRange = 60,
                Name = "Orc Settlement",
                Description =
                    "You gain access to the Scrapper race trait.",
                Traits =
                {
                    TraitEnum.Scrapper,
                },
            },
            #endregion

            #region "No True Homeland"
            //76–90	No True Homeland You have lived a life on the run and gain access to the Outcast race trait.
            new RandomTableEntry
            {
                LowerRange = 76,
                UpperRange = 90,
                Name = "No True Homeland",
                Description =
                    "You have lived a life on the run " +
                    "and gain access to the Outcast " +
                    "race trait.",
                Traits =
                {
                    TraitEnum.Outcast,
                },
            },
            #endregion
                        
            #region "Unusual Homeland."
            //91–100 Unusual Homeland.	Roll on Table:
            //Unusual Homeland.
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 100,
                Name = "Unusual Homeland",
                AlternateTable = BackgroundTables.UnusualHomelandTable,
            },
            #endregion
        ],
    };

    //Table: Half-Orc Parents
    //d%	Result
    //01–10	Both of your parents are alive.
    //11–35	Only your father is alive.
    //36–60	Only your mother is alive.
    //61–100	Both of your parents are dead. You gain access to the Orphaned social trait.
    /// <summary>
    /// The parents table
    /// </summary>
    private static RandomTable ParentsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Both"
            //01–10	Both of your parents are alive.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 10,
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //11–35	Only your father is alive.
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 35,
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //36–60	Only your mother is alive.
            new RandomTableEntry
            {
                LowerRange = 36,
                UpperRange = 60,
                Name = "Mother Only",
                Description = "Only your mother is alive.",
            },
            #endregion

            #region "Both Dead"
            //61–100 Both of your parents are dead.
            //You gain access to the Orphaned social
            //trait.
            new RandomTableEntry
            {
                LowerRange = 61,
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

    //Table: Half-Orc Siblings
    //d%	Result
    //01–60	1d6+1 orc siblings.You gain access to the Kin Guardian combat trait.
    //61–70	1d4 human siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.
    //71–80	One half-orc sibling.
    //81–100	No siblings.
    /// <summary>
    /// The siblings table
    /// </summary>
    private static RandomTable SiblingsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "1d6+1"
            //01–60	1d6+1 orc siblings.You gain access to the Kin Guardian combat trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 60,
                Name = "1d6+1",
                Description =
                    "1d6+1 orc siblings.You gain access " +
                    "to the Kin Guardian combat trait.",
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d4"
            //61–70	1d4 human siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 70,
                Name = "1d4",
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

            #region "1d1"
            //71–80	One half-orc sibling.
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 80,
                Name = "1d1",
                Description =
                    "One half-orc sibling.",
                Traits =
                {
                    TraitEnum.KinBond,
                },
            },
            #endregion

            #region "No siblings"
            //81–100	No siblings.
            new RandomTableEntry
            {
                LowerRange = 81,
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
    //Gender    Base Height    Height Modifier Base Weight Weight Modifier
    //Male	    4 ft. 10 in.	+2d12 in.       150 lbs.    +(2d12×7 lbs.)
    //Female	4 ft. 5 in.	    +2d12 in.       110 lbs.    +(2d12×7 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private static void SetHeightAndWeight(Character creature)
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
            // 150 lbs.    +(2d12×7 lbs.)
            creature.Weight = 150 + (new Dice("2d12").Total * 7);
        }

        if (creature?.Gender?.GenderEnum == GenderEnum.Female)
        {
            var modifier = new Dice("2d10").Total;
            if (modifier <= 6)
            {
                creature.Height = $"4 ft. {modifier + 5} in.";
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
            // 110 lbs. +(2d12×7 lbs.)
            creature.Weight = 110 + (new Dice("2d12").Total * 7);
        }
    }

    //Table: Random Starting Ages
    //Adulthood   Intuitive1    Self-Taught2   Trained3
    //14 years	    +1d4 years    +1d6 years  +2d6 years
    //1 This category includes barbarians, oracles, rogues, and sorcerers.
    //2 This category includes bards, cavaliers, fighters, gunslingers, paladins, rangers, summoners, and witches.
    //3 This category includes alchemists, clerics, druids, inquisitors, magi, monks, and wizards.    /// <summary>
    /// <summary>
    /// The age
    /// </summary>
    /// <param name="creature"></param>
    private static void SetAge(Character creature)
    {
        creature.Age = 14;

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