using Microsoft.Extensions.Logging;

using NetGore.Core;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Background;
using NetGore.Data.Services;

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
public class Dwarf : IRace
{
    private ILogger? _logger;

    /// <summary>
    /// Constructor for the character.
    /// </summary>
    /// <param name = "character" > The character (NPC or Player)</param>
    public Dwarf(Character character)
    {
        Initialize(character);
    }

    public Dwarf(ILoggerFactory logger,
        ICharacterService characterService)
    {
        _logger = logger.CreateLogger<Dwarf>();
        Initialize(new Character(logger));
    }

    /// <summary>
    /// Initialize all the race properties of the character
    /// </summary>
    /// <param name="creature"></param>
    public void Initialize(Character creature)
    {
        creature.RaceName = nameof(Dwarf);
        creature.Description = "Your dwarf character " +
            "has an assortment of inborn abilities, " +
            "part and parcel of dwarven nature.";

        //Ability Score Increase. Your Constitution score
        //increases by 2.
        creature.Constitution.RacialModifier = 2;

        //Size: Dwarves are Medium creatures and
        //thus receive no bonuses or penalties due
        //to their size.
        creature.Size = SizeEnum.Medium;

        // Set the height and weight
        SetHeightAndWeight(creature);
        SetAge(creature);

        //Base Speed: (Slow and Steady) Dwarves have
        //a base speed of 20 feet, but their speed
        //is never modified by armor or encumbrance.
        creature.Speed = 20;

        //Type: Dwarves are humanoids with the
        //dwarf subtype.
        creature.RaceType = RaceType.Humanoid;
        creature.RaceSubType.Add(RaceSubType.Dwarf);

        //Languages: Dwarves begin play speaking
        //Common and Dwarven. Dwarves with high
        //Intelligence scores can choose from the
        //following: Giant, Gnome, Goblin, Orc,
        //Terran, and Undercommon. 
        creature.Languages.Add(LanguageEnum.Common);
        creature.Languages.Add(LanguageEnum.Dwarven);
    }

    //Table: Dwarf Homeland
    //d%	Result
    //01–40	Hills or Mountains You gain access to the Goldsniffer race trait and the Highlander regional trait.
    //41–80	Underground You gain access to the Surface Stranger regional trait and the Tunnel Fighter race trait.
    //81–87	Non-Dwarven Town or Village You gain access to the Brewmaster race trait and the Militia Veteran regional trait.
    //88–95	Non-Dwarven City or Metropolis  You gain access to the Brewmaster race trait and the Vagabond Child regional trait.
    //96–100	Unusual Homeland.	Roll on Table: Unusual Homeland.
    /// <summary>
    /// The homeland table
    /// </summary>
    private static RandomTable HomelandTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Hills or Mountains"
            //01–40	Hills or Mountains You gain
            //access to the Goldsniffer race trait
            //and the Highlander regional trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 40,
                Name = "Hills or Mountains",
                Description =
                    "You gain access to the " +
                    "Goldsniffer race trait and " +
                    "the Highlander regional trait.",
                Traits =
                {
                    RacialTraitEnum.Goldsniffer,
                    RacialTraitEnum.Highlander
                },
            },
            #endregion

            #region Underground
            //41–80	Underground You gain access to
            //the Surface Stranger regional trait
            //and the Tunnel Fighter race trait.
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 80,
                Name = "Underground",
                Description =
                    "You gain access to the Surface " +
                    "Stranger regional trait and the " +
                    "Tunnel Fighter race trait.",
                Traits =
                {
                    RacialTraitEnum.SurfaceStranger,
                    RacialTraitEnum.TunnelFighter,
                },

            },
            #endregion

            #region "Non-Dwarven Town or Village"
            //81–87	Non-Dwarven Town or Village You
            //gain access to the Brewmaster race
            //trait and the Militia Veteran regional
            //trait.
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 87,
                Name = "Non-Dwarven Town or Village",
                Description =
                    "You gain access to the Brewmaster " +
                    "race trait and the Militia Veteran " +
                    "regional trait.",
                Traits =
                {
                    RacialTraitEnum.Brewmaster,
                    RacialTraitEnum.MilitiaVeteran,
                },
            },
            #endregion

            #region "Non-Dwarven City or Metropolis"
            // 88–95 Non-Dwarven City or Metropolis
            // You gain access to the Brewmaster race
            // trait and the Vagabond Child regional
            // trait.
            new RandomTableEntry
            {
                LowerRange = 88,
                UpperRange = 95,
                Name = "Non-Dwarven City or Metropolis",
                Description =
                    "You gain access to the Brewmaster " +
                    "race trait and the Vagabond Child " +
                    "regional trait.",
                Traits =
                {
                    RacialTraitEnum.Brewmaster,
                    RacialTraitEnum.VagabondChild,
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

    //Table: Dwarf Parents
    //d%	Result
    //01–60	Both of your parents are alive.
    //61–73	Only your father is alive.
    //74–86	Only your mother is alive.
    //87–100	Both of your parents are dead. You gain access to the Orphaned social trait.    
    /// <summary>
    /// The parents table
    /// </summary>
    private static RandomTable ParentsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "Both"
            //01–60	Both of your parents are alive.            new RandomTableEntry
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 60,
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //61–73	Only your father is alive.
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 73,
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //74–86	Only your mother is alive.
            new RandomTableEntry
            {
                LowerRange = 74,
                UpperRange = 86,
                Name = "Mother Only",
                Description = "Only your mother is alive.",
            },
            #endregion

            #region "Both Dead"
            //87–100 Both of your parents are dead.
            //You gain access to the Orphaned social
            //trait.    
            new RandomTableEntry
            {
                LowerRange = 87,
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

    //Table: Dwarf Siblings
    //d%	Result
    //01–80	1d4 biological siblings.With two or more siblings, you gain access to the Kin Guardian combat trait.
    //81–90	1d4+1 biological siblings. You gain access to the Kin Guardian combat trait.
    //91–95	1d3–1 biological siblings and 1d3–1 adopted siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
    //96–100	No siblings    
    /// <summary>
    /// The siblings table
    /// </summary>
    private static RandomTable SiblingsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "1d4"
            //01–80	1d4 biological siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 80,
                Name = "1d4",
                Description =
                    "1d4 biological siblings. With two " +
                    "or more siblings, you gain access " +
                    "to the Kin Guardian combat trait.",
                Traits =
                {
                    RacialTraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d4+1"
            //81–90	1d4+1 biological siblings. You gain access to the Kin Guardian combat trait.
            new RandomTableEntry
            {
                LowerRange = 81,
                UpperRange = 90,
                Name = "1d4+1",
                Description =
                    "1d4+1 biological siblings. You gain access to " +
                    "the Kin Guardian combat trait.",
                Traits =
                {
                    RacialTraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d3–1 and 1d3–1"
            //91–95	1d3–1 biological siblings and 1d3–1 adopted siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 95,
                Name = "1d3",
                Description = "1d3–1 Biological siblings and " +
                    "1d3–1 adopted siblings. With two or " +
                    "more siblings, you gain access to the " +
                    "Kin Guardian combat trait. Roll on Table: " +
                    "Race Table to determine the " +
                    "race of any adopted siblings.",
                AlternateTable = RaceService.RaceTable,
                Traits =
                {
                    RacialTraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "No siblings"
            //96–100 No siblings    
            new RandomTableEntry
            {
                LowerRange = 96,
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
    private static void SetAge(Character creature)
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
                creature.Height = $"4 ft. {modifier - 3} in.";
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
}