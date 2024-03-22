using System.Linq;

using NetGore.Core;
using NetGore.Core.Enum;
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

    /// <summary>
    /// Generate the character background
    /// </summary>
    public static void GenerateBackground(PlayerCharacter character)
    {
        #region Homeland
        var homeland = (BackgroundTableEntry?) HomelandTable.GetRandomEntry();
        if (homeland?.Name == "Unusual Homeland")
        {
            homeland = (BackgroundTableEntry?) BackgroundTables.UnusualHomelandTable.GetRandomEntry();
        }
        character.Homeland = homeland?.Name;
        if (homeland?.RacialTraits != null)
        {
            foreach (var trait in homeland.RacialTraits)
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
        if (parents?.RacialTraits != null)
        {
            foreach (var trait in parents.RacialTraits)
            {
                if (!character.RacialTraits.Contains(trait))
                {
                    character.RacialTraits.Add(trait);
                }
            }
        }
        #endregion


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
            new BackgroundTableEntry
            {
                LowerRange = 01,
                UpperRange = 40,
                Name = "Hills or Mountains",
                Description =
                    "You gain access to the " +
                    "Goldsniffer race trait and " +
                    "the Highlander regional trait.",
                RacialTraits =
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
            new BackgroundTableEntry
            {
                LowerRange = 41,
                UpperRange = 80,
                Name = "Underground",
                Description =
                    "You gain access to the Surface " +
                    "Stranger regional trait and the " +
                    "Tunnel Fighter race trait.",
                RacialTraits =
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
            new BackgroundTableEntry
            {
                LowerRange = 81,
                UpperRange = 87,
                Name = "Non-Dwarven Town or Village",
                Description = 
                    "You gain access to the Brewmaster " +
                    "race trait and the Militia Veteran " +
                    "regional trait.",
                RacialTraits =
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
            new BackgroundTableEntry
            {
                LowerRange = 88,
                UpperRange = 95,
                Name = "Non-Dwarven City or Metropolis",
                Description =
                    "You gain access to the Brewmaster " +
                    "race trait and the Vagabond Child " +
                    "regional trait.",
                RacialTraits =
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
            //01–60	Both of your parents are alive.            new BackgroundTableEntry
            new BackgroundTableEntry
            {
                LowerRange = 01,
                UpperRange = 60,
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //61–73	Only your father is alive.
            new BackgroundTableEntry
            {
                LowerRange = 61,
                UpperRange = 73,
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //74–86	Only your mother is alive.
            new BackgroundTableEntry
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
            new BackgroundTableEntry
            {
                LowerRange = 88,
                UpperRange = 95,
                Name = "Both Dead",
                Description =
                    "Both of your parents are dead. " +
                    "You gain access to the Orphaned " +
                    "social trait.",
                RacialTraits =
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
    /// The parents table
    /// </summary>
    private static RandomTable SiblingsTable { get; set; } = new()
    {
        DiceSides = 100,
        Table =
        [
            #region "1d4"
            //01–80	1d4 biological siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.
            new BackgroundTableEntry
            {
                LowerRange = 01,
                UpperRange = 80,
                Name = "1d4",
                Description =
                    "1d4 biological siblings. With two " +
                    "or more siblings, you gain access " +
                    "to the Kin Guardian combat trait.",
                RacialTraits =
                {
                    RacialTraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d4+1"
            //81–90	1d4+1 biological siblings. You gain access to the Kin Guardian combat trait.
            new BackgroundTableEntry
            {
                LowerRange = 81,
                UpperRange = 90,
                Name = "1d4+1",
                Description =
                    "1d4+1 biological siblings. You gain access to " +
                    "the Kin Guardian combat trait.",
                RacialTraits =
                {
                    RacialTraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "1d3–1 and 1d3–1"
            //91–95	1d3–1 biological siblings and 1d3–1 adopted siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
            new BackgroundTableEntry
            {
                LowerRange = 91,
                UpperRange = 95,
                Name = "1d3-1",
                Description = "1d3–1 Biological siblings and " +
                    "1d3–1 adopted siblings. With two or " +
                    "more siblings, you gain access to the " +
                    "Kin Guardian combat trait. Roll on Table: " +
                    "Race Table to determine the " +
                    "race of any adopted siblings.",
                AlternateTable = RaceService.RaceTable,
                RacialTraits =
                {
                    RacialTraitEnum.KinGuardian,
                },
            },
            #endregion

            #region "No siblings"
            //96–100 No siblings    
            new BackgroundTableEntry
            {
                LowerRange = 96,
                UpperRange = 100,
                Name = "No siblings",
                Description = "No siblings",
            },
            #endregion
        ],
    };
}