using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Background;

namespace NetGore.Data.Race;

/// <summary>
/// Social and amicable by nature, halflings fit 
/// equally well in both communities of humans 
/// and those of their wily kinsfolk. Prone to 
/// wanderlust, halflings can be found anywhere 
/// civilized humanoids settle.
/// </summary>
public class Halfling : IRace
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Halfling(Character creature)
    {
        Initialize(creature);
    }

    /// <summary>
    /// Initialize the creature
    /// </summary>
    /// <param name="creature"></param>
    public void Initialize(Character creature)
    {
        creature.RaceName = nameof(Halfling);
        creature.RaceDescription =
            "Your halfling character has a " +
            "number of traits in common " +
            "with all other halflings.";

        //Ability Score Increase.Your Dexterity
        //score increases by 2.
        creature.Dexterity.RacialModifier += 2;

        // Size. Your size is Medium.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Small;

        // Speed.Your base walking speed is 25 feet.
        creature.Speed = 25;
    }

    //Table: Halfling Homeland
    //d%	Result
    //01–50	Halfling Settlement You gain access to the Civilized social trait and the Well-Informed race trait.
    //51–80	Human Settlement    You gain access to the Child of the Streets social trait and the Well-Informed race trait.
    //81–95	Traveling Band or Caravan   You gain access to the Friend in Every Town social trait.
    //96–100	Unusual Homeland.	Roll on Table: Unusual Homeland.
    /// <summary>
    /// The homeland table
    /// </summary>
    private static RandomTable HomelandTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Halfling Settlement"
            //01–50	Halfling Settlement You gain access to the Civilized social trait and the Well-Informed race trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 50,
                Name = "Halfling Settlement",
                Description =
                    "You gain access to the Civilized " +
                    "social trait and the Well-Informed " +
                    "race trait.",
                Traits =
                {
                    RacialTraitEnum.Civilized,
                    RacialTraitEnum.WellInformed,
                },
            },
            #endregion

            #region "Human Settlement"
            //51–80	Human Settlement You gain access to the Child of the Streets social trait and the Well-Informed race trait.
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 80,
                Name = "Human Homeland",
                Description =
                    "You gain access to the Child of the Streets social trait and the Well-Informed race trait.",
                Traits =
                {
                    RacialTraitEnum.ChildoftheStreets,
                    RacialTraitEnum.WellInformed,
                },
            },
            #endregion

            #region "Traveling Band or Caravan"
            //81–95	Traveling Band or Caravan You gain
            //access to the Friend in Every Town social
            //trait.
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 95,
                Name = "Traveling Band or Caravan",
                Description =
                    "You gain access to the Friend in Every Town social trait.",
                Traits =
                {
                    RacialTraitEnum.FriendinEveryTown,
                },
            },
            #endregion
                        
            #region "Unusual Homeland."
            //96–100 Unusual Homeland.	Roll on Table:
            //Unusual Homeland.
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

    //Table: Halfling Parents
    //d%	Result
    //01–70	Both parents living.
    //71–80	Only your father is alive.
    //81–90	Only your mother is alive.
    //91–100	Both of your parents are dead.You gain access to the Orphaned social trait
    /// <summary>
    /// The parents table
    /// </summary>
    private static RandomTable ParentsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Both"
            //01–70	Both of your parents are alive.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 70,
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //71–80	Only your father is alive.
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 80,
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //81–90	Only your mother is alive.
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 90,
                Name = "Mother Only",
                Description = "Only your mother is alive.",
            },
            #endregion

            #region "Both Dead"
            //91–100 Both of your parents are dead.
            //You gain access to the Orphaned social
            //trait.
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 100,
                Name = "Both Dead",
                Description =
                    "Both of your parents are dead. " +
                    "You gain access to the Orphaned " +
                    "social trait.",
                Traits =
                {
                    RacialTraitEnum.Orphaned,
                },
            },
            #endregion
        ],
    };

    //Table: Halfling Siblings
    //d%	Result
    //01–30	1d2 siblings.With two siblings, you gain access to the Kin Guardian combat trait.
    //31–90	1d4+1 siblings.You gain access to the Kin Guardian combat trait.
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
            //01–30	1d2 siblings.With two siblings,
            //you gain access to the Kin Guardian
            //combat trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 30,
                Name = "1d2",
                Description =
                    "1d2 siblings. With two siblings, you gain access to the Kin Guardian combat trait.",
                Traits =
                {
                    RacialTraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d4+1"
            //1d4+1 siblings. You gain access to the
            //Kin Guardian combat trait.
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 90,
                Name = "1d1",
                Description =
                    "1d4+1 siblings. You gain access to the Kin Guardian combat trait.",
                Traits =
                {
                    RacialTraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "No siblings"
            //91–100	No siblings.
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
                if (!character.RacialTraits.Contains(RacialTraitEnum.KinGuardian))
                {
                    character.RacialTraits.Add(RacialTraitEnum.KinGuardian);
                }
            }
        }
        #endregion
    }

    //Table: Random Height and Weight
    //Gender Base Height    Height Modifier Base Weight Weight Modifier
    //Male	    2 ft. 8 in.	 +2d4 in.        30 lbs. +(2d4 lbs.)
    //Female	2 ft. 6 in.	 +2d4 in.        25 lbs. +(2d4 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private static void SetHeightAndWeight(Character creature)
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
    private static void SetAge(Character creature)
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