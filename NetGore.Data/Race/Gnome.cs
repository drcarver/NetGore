using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Background;

namespace NetGore.Data.Race;

/// <summary>
/// The capricious and carefree gnomes of the 
/// world are widespread and varied. They 
/// typically either form their own gnome 
/// communities or integrate themselves into 
/// other humanoid societies.
/// </summary>
public class Gnome : IRace
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Gnome(Character creature)
    {
        Initialize(creature);
    }

    /// <summary>
    /// Initialize all the race properties of the character
    /// </summary>
    /// <param name="character"></param>
    public void Initialize(Character creature)
    {
        creature.RaceName = nameof(Gnome);
        creature.RaceDescription =
            "Your gnome character has certain " +
            "characteristics in common with all " +
            "other gnomes.";

        //Ability Score Increase.Your Intelligence
        //score increases by 2.
        creature.Intelligence.RacialModifier = 2;

        //Size: Gnomes are Small creatures and
        //thus gain a +1 size bonus to their
        //AC, a + 1 size bonus on attack rolls,
        //a –1 penalty to their Combat Maneuver
        //Bonus and Combat Maneuver Defense,
        //and a + 4 size bonus on Stealth checks.
        SetHeightAndWeight(creature);
        SetAge(creature);
        creature.Size = SizeEnum.Small;

        //Base Speed: (Slow Speed) Gnomes have a
        //base speed of 20 feet.
        creature.Speed = 20;

        //Type: Gnomes are Humanoid creatures with
        //the gnome subtype.
        creature.RaceType = RaceType.Humanoid;
        creature.RaceSubType.Add(RaceSubType.Gnome);

        //Languages: Gnomes begin play speaking
        //Common, Gnome, and Sylvan. Gnomes with
        //high Intelligence scores can choose from
        //the following: Draconic, Dwarven, Elven,
        //Giant, Goblin, and Orc.
        creature.Languages.Add(LanguageEnum.Common);
        creature.Languages.Add(LanguageEnum.Gnome);
        creature.Languages.Add(LanguageEnum.Sylvan);
    }

    //Table: Gnome Homeland
    //d%	Result
    //01–30	Forest You gain access to the Log Roller regional trait and the Animal Friend race trait.
    //31–65	Non-Gnome Town or Village   You gain access to the Animal Friend race trait.
    //66–95	Non-Gnome City or Metropolis    You gain access to the Rapscallion race trait.
    //96–100	Unusual Homeland.	Roll on Table: Unusual Homeland.
    /// <summary>
    /// The homeland table
    /// </summary>
    private static RandomTable HomelandTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Forest"
            //01–30	Forest You gain access to the
            //Log Roller regional trait and the
            //Animal Friend race trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 30,
                Name = "Forest",
                Description =
                    "You gain access to the " +
                    "Log Roller regional trait and " +
                    "the Animal Friend race trait.",
                Traits =
                {
                    TraitEnum.LogRoller,
                    TraitEnum.AnimalFriend
                },
            },
            #endregion

            #region "Non-Gnome Town or Village"
            //31–65	Non-Gnome Town or Village   You gain access to the Animal Friend race trait.
            new RandomTableEntry
            {
                LowerRange = 31,
                UpperRange = 65,
                Name = "Non-Gnome Town or Village",
                Description =
                    "You gain access to the Animal Friend race trait.",
                Traits =
                {
                    TraitEnum.AnimalFriend,
                },
            },
            #endregion

            #region "Non-Gnome City or Metropolis"
            //66–95	Non-Gnome City or Metropolis You gain access to the Rapscallion race trait.
            new RandomTableEntry
            {
                LowerRange = 66,
                UpperRange = 95,
                Name = "Non-Gnome City or Metropolis",
                Description =
                    "You gain access to the Rapscallion race trait.",
                Traits =
                {
                    TraitEnum.Rapscallion,
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

    //Table: Gnome Parents
    //d%	Result
    //01–90	Both of your parents are alive.
    //91–93	Only your father is alive.
    //94–96	Only your mother is alive.
    //97–100	Both of your parents are dead. You gain access to the Orphaned social trait.
    /// <summary>
    /// The parents table
    /// </summary>
    private static RandomTable ParentsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Both"
            //01–90	Both of your parents are alive.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 90,
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //91–93	Only your father is alive.
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 93,
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //94–96	Only your mother is alive.
            new RandomTableEntry
            {
                LowerRange = 94,
                UpperRange = 96,
                Name = "Mother Only",
                Description = "Only your mother is alive.",
            },
            #endregion

            #region "Both Dead"
            //97–100 Both of your parents are dead.
            //You gain access to the Orphaned social
            //trait.
            new RandomTableEntry
            {
                LowerRange = 97,
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

    //Table: Gnome Siblings
    //d%	Result
    //01–50	1d4 biological siblings.With two or more siblings, you gain access to the Kin Guardian combat trait.
    //51–60	1d4–1 biological siblings and one adopted sibling. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
    //61–100	No siblings.
    /// <summary>
    /// The siblings table
    /// </summary>
    private static RandomTable SiblingsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "1d4"
            //01–50	1d4 biological siblings.With two or more siblings, you gain access to the Kin Guardian combat trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 50,
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

            #region "1d4-1"
            //51–60	1d4–1 biological siblings and one adopted sibling. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 60,
                Name = "1d4",
                Description =
                    "1d4–1 biological siblings and " +
                    "one adopted sibling. With two " +
                    "or more siblings, you gain " +
                    "access to the Kin Guardian " +
                    "combat trait. Roll on Table: " +
                    "Race to determine the race " +
                    "of any adopted siblings.",
                Traits =
                {
                    TraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "No siblings"
            //61–100	No siblings.
            new RandomTableEntry
            {
                LowerRange = 61,
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
    //Male	 3 ft. 0 in.	+2d4 in.  35 lbs. +(2d4 lbs.)
    //Female 2 ft. 10 in.	+2d4 in.  30 lbs. +(2d4 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The dwarf</param>
    private static void SetHeightAndWeight(Creature creature)
    {
        if (creature?.Gender?.GenderEnum == GenderEnum.Male)
        {
            // 3 ft. 0 in.	+2d4 in.
            creature.Height = $"3 ft. {new Dice("2d8").Total} in.";

            // 35 lbs. +(2d4 lbs.)
            creature.Weight = 35 + new Dice("2d4").Total;
        }

        // Female 2 ft. 10 in.	+2d4 in.
        if (creature?.Gender?.GenderEnum == GenderEnum.Female)
        {
            var modifier = new Dice("2d4").Total;
            if (modifier == 2)
            {
                creature.Height = $"3 ft.";
            }
            else
            {
                creature.Height = $"3 ft. {modifier - 3} in.";
            }
            // 30 lbs. +(2d4 lbs.)
            creature.Weight = 30 + new Dice("2d4").Total;
        }
    }

    //Table: Random Starting Ages
    //Adulthood   Intuitive1    Self-Taught2 Trained3
    //40 years	  +4d6 years    +6d6 years    +9d6 years
    //1 This category includes barbarians, oracles, rogues, and sorcerers.
    //2 This category includes bards, cavaliers, fighters, gunslingers, paladins, rangers, summoners, and witches.
    //3 This category includes alchemists, clerics, druids, inquisitors, magi, monks, and wizards.    
    /// <summary>
    /// Set the age
    /// </summary>
    /// <param name="creature"></param>
    private static void SetAge(Character creature)
    {
        creature.Age = 40;

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
            creature.Age += new Dice("9d6").Total;
        }
    }
}