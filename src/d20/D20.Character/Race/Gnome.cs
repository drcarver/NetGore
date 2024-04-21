using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Character.Tables;
using D20.Core;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Character.Race;

/// <summary>
/// The capricious and carefree gnomes of the 
/// world are widespread and varied. They 
/// typically either form their own gnome 
/// communities or integrate themselves into 
/// other humanoid societies.
/// </summary>
public class Gnome : ICharacterRace
{
    /// <summary>
    /// Set the race traits for the creature.
    /// </summary>
    /// <param name="creature"></param>
    public Gnome(ICharacter creature)
    {
        Initialize(creature);
    }

    /// <summary>
    /// Initialize all the race properties of the character
    /// </summary>
    /// <param name="character"></param>
    public void Initialize(ICharacter creature)
    {
        creature.Race = RaceEnum.Gnome;

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
        creature.RaceSubType.Add(RaceSubTypeEnum.Gnome);

        //Languages: Gnomes begin play speaking
        //Common, Gnome, and Sylvan. Gnomes with
        //high Intelligence scores can choose from
        //the following: Draconic, Dwarven, Elven,
        //Giant, Goblin, and Orc.
        creature.Languages.Add(LanguageEnum.Common);
        creature.Languages.Add(LanguageEnum.Gnomish);
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
            new BackgroundTableEntry
            {
                Range = new Range(01,30),
                Name = "Forest",
                Description =
                    "You gain access to the " +
                    "Log Roller regional trait and " +
                    "the Animal Friend race trait.",
                Traits =
                {
                    TraitEnum.AnimalFriend
                },
            },
            #endregion

            #region "Non-Gnome Town or Village"
            //31–65	Non-Gnome Town or Village   You gain access to the Animal Friend race trait.
            new BackgroundTableEntry
            {
                Range = new Range(31,65),
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
            new BackgroundTableEntry
            {
                Range = new Range(66,95),
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
            new BackgroundTableEntry
            {
                Range = new Range(96,100),
                Name = "Unusual Homeland",
                AlternateTable = typeof(UnusualHomelandTable),
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
            new BackgroundTableEntry
            {
                Range = new Range(01,90),
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //91–93	Only your father is alive.
            new BackgroundTableEntry
            {
                Range = new Range(91,93),
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //94–96	Only your mother is alive.
            new BackgroundTableEntry
            {
                Range = new Range(94,96),
                Name = "Mother Only",
                Description = "Only your mother is alive.",
            },
            #endregion

            #region "Both Dead"
            //97–100 Both of your parents are dead.
            //You gain access to the Orphaned social
            //trait.
            new BackgroundTableEntry
            {
                Range = new Range(97,100),
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
            new BackgroundTableEntry
            {
                Range = new Range(01,50),
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
            new BackgroundTableEntry
            {
                Range = new Range(51,60),
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
            new BackgroundTableEntry
            {
                Range = new Range(61,100),
                Name = "No siblings",
                Description = "No siblings",
            },
            #endregion
        ],
    };

    /// <summary>
    /// Generate the character background
    /// </summary>
    public void GenerateRaceBackground(D20Character character)
    {
        #region Homeland
        character.Homeland = (BackgroundTableEntry?)HomelandTable.GetRandomEntry();
        if (character.Homeland?.Name == "Unusual Homeland")
        {
            //homeland = (BackgroundTableEntry?)BackgroundTables.UnusualHomelandTable.GetRandomEntry();
        }
        if (character.Homeland?.Traits != null)
        {
            foreach (var trait in character.Homeland.Traits)
            {
                if (!character.Traits.Contains(trait))
                {
                    character.Traits.Add(trait);
                }
            }
        }
        #endregion

        #region Parents
        character.Parents = (BackgroundTableEntry?)ParentsTable.GetRandomEntry();
        if (character.Parents?.Traits != null)
        {
            foreach (var trait in character.Parents.Traits)
            {
                if (!character.Traits.Contains(trait))
                {
                    character.Traits.Add(trait);
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

                // Set relative age of sibling
                //var relativeage = BackgroundTables.RelativeAgeofSiblingTable.GetRandomEntry();
                //if (relativeage?.Name == "Younger")
                //{
                //    creaturesiblings.Age -= new Dice("1d4").Total;
                //}
                //if (relativeage?.Name == "Older")
                //{
                //    creaturesiblings.Age += new Dice("1d4").Total;
                //}

                //character.Siblings.Add(creaturesiblings);
            }
            if (character.Siblings.Count > 0)
            {
                if (!character.Traits.Contains(TraitEnum.KinGuardian))
                {
                    character.Traits.Add(TraitEnum.KinGuardian);
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
    private static void SetHeightAndWeight(ICreature creature)
    {
        if (creature?.Gender == GenderEnum.Male)
        {
            // 3 ft. 0 in.	+2d4 in.
            //creature.Height = $"3 ft. {new Dice("2d8").Total} in.";

            // 35 lbs. +(2d4 lbs.)
            //creature.Weight = 35 + new Dice("2d4").Total;
        }

        // Female 2 ft. 10 in.	+2d4 in.
        if (creature?.Gender == GenderEnum.Female)
        {
            var modifier = new Dice("2d4").Total;
            if (modifier == 2)
            {
                //creature.Height = $"3 ft.";
            }
            else
            {
                //creature.Height = $"3 ft. {modifier - 3} in.";
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
    private static void SetAge(ICharacter creature)
    {
    }

    public void GenerateBackground(IRandomTable homelandTable, IRandomTable unusualHomelandTable, IRandomTable parentsTable, IRandomTable siblingsTable, IRandomTable relativeAgeofSiblings)
    {
        throw new NotImplementedException();
    }
}