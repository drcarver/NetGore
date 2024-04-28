using GoDungeon.Background.Enum;
using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
    /// <summary>
    /// Only rarely the result of a happy union between 
    /// the humans and orcs that bring them into the 
    /// world, half-orcs are often regarded as monsters. 
    /// This bleak reality makes those rare half-orcs, 
    /// cherished as much as the young of any other race, 
    /// even more extraordinary.
    /// </summary>
    public class HalfOrcViewModel : CharacterRaceViewModel, IHalfOrc
    {
        /// <summary>
        /// Set the race traits for the 
        /// </summary>
        public HalfOrcViewModel(ILoggerFactory logger)
        {
            Initialize();
        }

        /// <summary>
        /// Initialize the creature
        /// </summary>
        /// <param name="creature"></param>
        public void Initialize()
        {
            Race = RaceEnum.HalfOrc;

            //Ability Score Modifiers: Half - orc
            //characters gain a + 2 bonus to Strength
            //and +1 bonus to constitution
            Strength.RacialModifier = 2;
            Constitution.RacialModifier = 1;

            //Size: Half - orcs are Medium creatures
            //and thus have no bonuses or penalties due
            //to their size.
            SetHeightAndWeight();
            Size = SizeEnum.Medium;

            //Base Speed: Half - orcs have a base
            //speed of 30 feet.
            Speed = 30;

            //Type: Half - orcs are Humanoid creatures
            //with both the human and orc subtypes.
            RaceType = RaceType.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Human);
            RaceSubType.Add(RaceSubTypeEnum.Orc);

            //Languages: Half - orcs begin play speaking
            //Common and Orc. Half - orcs with high
            //Intelligence scores can choose from the
            //following: Abyssal, Draconic, Giant, Gnoll,
            //and Goblin.
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Orc);
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
                new BackgroundTableEntry
                {
                    Range = new Range(01,25),
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
                new BackgroundTableEntry
                {
                    Range = new Range(61,75),
                    Name = "Raised in a Human Homeland",
                    Description = "Roll on Table: Human Homeland",
                    //AlternateTable = Human.HomelandTable
                },
                #endregion

                #region "Orc Settlement"
                //26–60	Orc Settlement  You gain access to the Scrapper race trait.
                new BackgroundTableEntry
                {
                    Range = new Range(26,60),
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
                new BackgroundTableEntry
                {
                    Range = new Range(76,90),
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
                new BackgroundTableEntry
                {
                    Range = new Range(91,100),
                    Name = "Unusual Homeland",
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
                new BackgroundTableEntry
                {
                    Range = new Range(01,10),
                    Name = "Both Alive",
                    Description = "Both of your parents are alive.",
                },
                #endregion

                #region "Father Only"
                //11–35	Only your father is alive.
                new BackgroundTableEntry
                {
                    Range = new Range(11,35),
                    Name = "Father Only",
                    Description = "Only your father is alive.",
                },
                #endregion

                #region "Mother Only"
                //36–60	Only your mother is alive.
                new BackgroundTableEntry
                {
                    Range = new Range(36,60),
                    Name = "Mother Only",
                    Description = "Only your mother is alive.",
                },
                #endregion

                #region "Both Dead"
                //61–100 Both of your parents are dead.
                //You gain access to the Orphaned social
                //trait.
                new BackgroundTableEntry
                {
                    Range = new Range(61,100),
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
                new BackgroundTableEntry
                {
                    Range = new Range(01,60),
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
                new BackgroundTableEntry
                {
                    Range = new Range(61,70),
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
                new BackgroundTableEntry
                {
                    Range = new Range(71,80),
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
                new BackgroundTableEntry
                {
                    Range = new Range(81,100),
                    Name = "No siblings",
                    Description = "No siblings",
                },
                #endregion
            ],
        };

        //Table: Random Height and Weight
        //Gender    Base Height    Height Modifier Base Weight Weight Modifier
        //Male	    4 ft. 10 in.	+2d12 in.       150 lbs.    +(2d12×7 lbs.)
        //Female	4 ft. 5 in.	    +2d12 in.       110 lbs.    +(2d12×7 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
        /// <param name="creature">The player character</param>
        private void SetHeightAndWeight()
        {
            if (Gender == GenderEnum.Male)
            {
                var modifier = new Dice("2d10").Total;
                if (modifier <= 1)
                {
                    //Height = $"4 ft. {modifier + 10} in.";
                }
                else if (modifier == 2)
                {
                    //Height = $"5 ft.";
                }
                else if (modifier <= 13 && modifier >= 3)
                {
                    //Height = $"5 ft. {modifier - 2} in.";
                }
                else
                {
                    //Height = $"6 ft. {modifier - 13} in.";
                }
                // 150 lbs.    +(2d12×7 lbs.)
                Weight = 150 + new Dice("2d12").Total * 7;
            }

            if (Gender == GenderEnum.Female)
            {
                var modifier = new Dice("2d10").Total;
                if (modifier <= 6)
                {
                    //Height = $"4 ft. {modifier + 5} in.";
                }
                else if (modifier == 7)
                {
                    //Height = $"5 ft.";
                }
                else if (modifier <= 19 && modifier >= 8)
                {
                    //Height = $"5 ft. {modifier - 8} in.";
                }
                else
                {
                    //Height = $"6 ft.";
                }
                // 110 lbs. +(2d12×7 lbs.)
                Weight = 110 + new Dice("2d12").Total * 7;
            }
        }
    }
}