using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Background;

namespace NetGore.Data.Race;

/// <summary>
/// The capricious and carefree gnomes of the world 
/// are widespread and varied. They typically either 
/// form their own gnome communities or integrate 
/// themselves into other humanoid societies.
/// </summary>
public class HalfElf : IRace
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public HalfElf(Character creature)
    {
        Initialize(creature);
    }

    /// <summary>
    /// Initialize the creature
    /// </summary>
    /// <param name="creature"></param>
    public void Initialize(Character creature) 
    {
        creature.RaceName = nameof(HalfElf);
        creature.RaceDescription =
            "Your half‑elf character has some " +
            "qualities in common with elves and " +
        "some that are unique to half‑elves.";

        //Ability Score Increase. Your Charisma
        //score increases by 2, and two other
        //ability scores of your choice increase
        //by 1.
        creature.Charisma.RacialModifier += 2;
        creature.Intelligence.RacialModifier += 1;
        creature.Dexterity.RacialModifier += 1;

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
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 25,
                Name = "Raised in an Elven Homeland",
                Description =
                    "Raised in an Elven Homeland. " +
                    "Roll on Table: Elf Homeland.",
                AlternateTable = Elf.HomelandTable
            },
            #endregion

            #region "Raised in a Human Homeland"
            //26–75	Raised in a Human Homeland.Roll on Table: Human Homeland.
            new RandomTableEntry
            {
                LowerRange = 26,
                UpperRange = 75,
                Name = "Raised in a Human Homeland",
                Description =
                    "Raised in a Human Homeland. Roll on Table: Human Homeland.",
                AlternateTable = Human.HomelandTable
            },
            #endregion

            #region "Forest"
            //76–95	Forest You gain access to the Log
            //Roller regional trait.
            new RandomTableEntry
            {
                LowerRange = 76,
                UpperRange = 95,
                Name = "Forest",
                Description =
                    "You gain access to the Log Roller regional trait.",
                Traits =
                {
                    TraitEnum.LogRoller,
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
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 20,
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //21–55	Only your father is alive.
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 55,
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //56–90	Only your mother is alive.
            new RandomTableEntry
            {
                LowerRange = 56,
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
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 50,
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
            new RandomTableEntry
            {
                LowerRange = 21,
                UpperRange = 30,
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
            new RandomTableEntry
            {
                LowerRange = 31,
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
    //Gender Base Height   Height Modifier Base Weight Weight Modifier
    //Male	 5 ft. 2 in.	+2d8 in.        100 lbs.    +(2d8×5 lbs.)
    //Female 5 ft. 0 in.	+2d8 in.         90 lbs.    +(2d8×5 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    private static void SetHeightAndWeight(Character creature)
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
    private static void SetAge(Character creature)
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