using GoDungeon.Background.Enum;
using GoDungeon.Background.Tables;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
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
    public class DwarfViewModel : CharacterRaceViewModel, IDwarf
    {
        private ILogger? _logger;
        private readonly ILoggerFactory loggerFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">The logging service</param>
        public DwarfViewModel(ILoggerFactory logger)
        {
            _logger = logger.CreateLogger<IDwarf>();
            loggerFactory = logger;
            Initialize();
        }

        /// <summary>
        /// Initialize all the race properties of the character
        /// </summary>
        public void Initialize()
        {
            Race = RaceEnum.Dwarf;

            //Ability Score Increase. Your Constitution score
            //increases by 2.
            Constitution.RacialModifier = 2;

            //Size: Dwarves are Medium creatures and
            //thus receive no bonuses or penalties due
            //to their size.
            Size = SizeEnum.Medium;

            // Height, Weight and Age
            //GetVitalStatistics();

            //Base Speed: (Slow and Steady) Dwarves have
            //a base speed of 20 feet, but their speed
            //is never modified by armor or encumbrance.
            Speed = 20;

            //Type: Dwarves are humanoids with the
            //dwarf subtype.
            RaceType = RaceType.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Dwarf);

            //Languages: Dwarves begin play speaking
            //Common and Dwarven. Dwarves with high
            //Intelligence scores can choose from the
            //following: Giant, Gnome, Goblin, Orc,
            //Terran, and Undercommon. 
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Dwarvish);
        }

        /// <summary>
        /// Set the height, weight and age of the creature
        /// </summary>
        /// <param name="creature">creature info</param>
        private void GetVitalStatistics(ICreature creature)
        {
            int feet = 3, inches = 9, weight = 150;
            string heightdice = "2d4";
            string weightdice = "2D4";
            if (Gender == GenderEnum.Male)
            {
                //BackgroundTables.HeightAndWeight(
                //    ref feet, ref inches, ref weight,
                //    heightdice, weightdice, 7);
                Weight = weight;
                //Height = $"{feet} ft. {inches} in.";
            }
            else
            {
                feet = 3; inches = 7; weight = 120;
                //BackgroundTables.HeightAndWeight(
                //    ref feet, ref inches, ref weight,
                //    heightdice, weightdice, 7);
                Weight = weight;
                //Height = $"{feet} ft. {inches} in.";
            }

            string intuitiveDice = "3d6";
            string selftaughtDice = "5d6";
            string trainedDice = "7d6";
            int startingAge = 40;
            //Age = BackgroundTables.CalculateCharacterAge(
            //    ClassEnum.Any, startingAge, intuitiveDice,
            //    selftaughtDice, trainedDice);
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
                    Range = new Range(01,40),
                    Name = "Hills or Mountains",
                    Description =
                        "You gain access to the " +
                        "Goldsniffer race trait and " +
                        "the Highlander regional trait.",
                    Traits =
                    {
                        TraitEnum.Goldsniffer,
                        TraitEnum.Highlander
                    },
                },
                #endregion

                #region Underground
                //41–80	Underground You gain access to
                //the Surface Stranger regional trait
                //and the Tunnel Fighter race trait.
                new BackgroundTableEntry
                {
                    Range = new Range(41,80),
                    Name = "Underground",
                    Description =
                        "You gain access to the Surface " +
                        "Stranger regional trait and the " +
                        "Tunnel Fighter race trait.",
                    Traits =
                    {
                        TraitEnum.SurfaceStranger,
                        TraitEnum.TunnelFighter,
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
                    Range = new Range(81,87),
                    Name = "Non-Dwarven Town or Village",
                    Description =
                        "You gain access to the Brewmaster " +
                        "race trait and the Militia Veteran " +
                        "regional trait.",
                    Traits =
                    {
                        TraitEnum.Brewmaster,
                        TraitEnum.MilitiaVeteran,
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
                    Range = new Range(88,95),
                    Name = "Non-Dwarven City or Metropolis",
                    Description =
                        "You gain access to the Brewmaster " +
                        "race trait and the Vagabond Child " +
                        "regional trait.",
                    Traits =
                    {
                        TraitEnum.Brewmaster,
                        TraitEnum.VagabondChild,
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
                //01–60	Both of your parents are alive.
                new BackgroundTableEntry
                {
                    Range = new Range(01,60),
                    Name = "Both Alive",
                    Description = "Both of your parents are alive.",
                },
                #endregion

                #region "Father Only"
                //61–73	Only your father is alive.
                new BackgroundTableEntry
                {
                    Range = new Range(61,73),
                    Name = "Father Only",
                    Description = "Only your father is alive.",
                },
                #endregion

                #region "Mother Only"
                //74–86	Only your mother is alive.
                new BackgroundTableEntry
                {
                    Range = new Range(74,86),
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
                    Range = new Range(87,100),
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
                new BackgroundTableEntry
                {
                    Range = new Range(01,80),
                    Name = "1d4",
                    Description =
                        "1d4 biological siblings. With two " +
                        "or more siblings, you gain access " +
                        "to the Kin Guardian combat trait.",
                    Traits =
                    {
                        TraitEnum.KinGuardian,
                    },
                },
                #endregion

                #region "1d4+1"
                //81–90	1d4+1 biological siblings. You gain access to the Kin Guardian combat trait.
                new BackgroundTableEntry
                {
                    Range = new Range(81,90),
                    Name = "1d4+1",
                    Description =
                        "1d4+1 biological siblings. You gain access to " +
                        "the Kin Guardian combat trait.",
                    Traits =
                    {
                        TraitEnum.KinGuardian,
                    },
                },
                #endregion

                #region "1d3–1 and 1d3–1"
                //91–95	1d3–1 biological siblings and 1d3–1 adopted siblings. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
                new BackgroundTableEntry
                {
                    Range = new Range(91,95),
                    Name = "1d3",
                    Description = "1d3–1 Biological siblings and " +
                        "1d3–1 adopted siblings. With two or " +
                        "more siblings, you gain access to the " +
                        "Kin Guardian combat trait. Roll on Table: " +
                        "Race Table to determine the " +
                        "race of any adopted siblings.",
                    Traits =
                    {
                        TraitEnum.KinGuardian,
                    },
                },
                #endregion

                #region "No siblings"
                //96–100 No siblings    
                new BackgroundTableEntry
                {
                    Range = new Range(96,100),
                    Name = "No siblings",
                    Description = "No siblings",
                },
                #endregion
            ],
        };
    }
}