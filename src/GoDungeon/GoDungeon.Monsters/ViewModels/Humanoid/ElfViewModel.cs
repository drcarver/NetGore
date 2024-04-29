using System;
using System.Collections.ObjectModel;

using GoDungeon.Background.ViewModels;
using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
    /// <summary>
    /// Elves are often raised in insular elven 
    /// communities, and the longevity of these 
    /// people means that elven children often 
    /// grow up with the help of a large social 
    /// network.
    /// </summary>
    public class ElfViewModel : CharacterRaceViewModel, IElf
    {
        /// <summary>
        /// Set the race traits for the 
        /// </summary>
        public ElfViewModel(ILoggerFactory loggerFactory)
        {
            Initialize();
        }

        /// <summary>
        /// Initialize the character
        /// </summary>
        public void Initialize()
        {
            Race = RaceEnum.Elf;

            //Ability Score Increase.Your Dexterity
            //score increases by 2.
            Dexterity.RacialModifier = 2;

            //Size: Elves are Medium creatures and thus
            //receive no bonuses or penalties due to
            //their size.
            SetHeightAndWeight();
            SetAge();
            Size = SizeEnum.Medium;

            //Base Speed: Elves have a base speed of
            //30 feet.
            Speed = 30;

            //Type: Elves are Humanoids with the elf
            //subtype.
            RaceType = RaceType.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Elf);

            //Languages: Elves begin play speaking Common
            //and Elven .Elves with high Intelligence
            //scores can choose from the following:
            //Celestial, Draconic, Gnoll, Gnome, Goblin,
            //Orc, and Sylvan. See the Linguistics skill
            //page for more information about these
            //languages.
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Elvish);

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
        public static RandomTable HomelandTable { get; set; } = new RandomTable
        {
            DiceSides = 100,
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region "Forest"
                //01–60	Forest You gain access to the
                //Log Roller regional trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01,60),
                    Name = "Forest",
                    Description =
                        "You gain access to the " +
                        "Log Roller regional trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                    },
                },
                #endregion

                #region "Non-Elven City or Metropolis"
                //61–80	Non-Elven City or Metropolis    
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(61,80),
                    Name = "Non-Elven City or Metropolis",
                    Description =
                        "If you’re an elf, you gain access " +
                        "to the Civilized social trait and " +
                        "the Forlorn race trait.If you’re " +
                        "a half-elf, you gain access to the " +
                        "Civilized social trait and the " +
                        "Failed Apprentice race trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Civilized
                    },

                },
                #endregion

                #region "Non-Elven Town or Village"
                //81–95	Non-Elven Town or Village
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(81,95),
                    Name = "Non-Dwarven Town or Village",
                    Description =
                        "You gain access to the Forlorn race trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Forlorn,
                    },
                },
                #endregion
                        
                #region "Unusual Homeland."
                //96–100	Unusual Homeland.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(96,100),
                    Name = "Unusual Homeland",
                },
                #endregion
            },
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
        private static RandomTable ParentsTable { get; set; } = new RandomTable
        {
            DiceSides = 100,
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region "Both"
                //01–79	Both of your parents are alive.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01,79),
                    Name = "Both Alive",
                    Description = "Both of your parents are alive.",
                },
                #endregion

                #region "Father Only"
                //80–87	Only your father is alive.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(80,87),
                    Name = "Father Only",
                    Description = "Only your father is alive.",
                },
                #endregion

                #region "Mother Only"
                //88–95	Only your mother is alive.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(88,95),
                    Name = "Mother Only",
                    Description = "Only your mother is alive.",
                },
                #endregion

                #region "Both Dead"
                //96–100 Both of your parents are dead.
                //You gain access to the Orphaned social
                //trait.    
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(96,100),
                    Name = "Both Dead",
                    Description =
                        "Both of your parents are dead. " +
                        "You gain access to the Orphaned " +
                        "social trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.Orphaned,
                    },

                },
                #endregion
            },
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
        private static RandomTable SiblingsTable { get; set; } = new RandomTable
        {
            DiceSides = 100,
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region "1d2"
                //01–80	1d2 biological siblings.If you roll 2 siblings, you gain access to the Kin Guardian combat trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01,80),
                    Name = "1d2",
                    Description =
                        "With two or more siblings, you gain access " +
                        "to the Kin Guardian combat trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.KinGuardian,
                    },
                },
                #endregion

                #region "1d4+1"
                //81–85	1d4+1 biological siblings. You gain access to the Kin Guardian combat trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(81,85),
                    Name = "1d4+1",
                    Description =
                        "You gain access to " +
                        "the Kin Guardian combat trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.KinGuardian,
                    },
                },
                #endregion

                #region "1d4+1 "
                //86–90	1d4+1 biological siblings. 1d3–1 of these siblings are half-elves, adopted, or a mix of the two (your choice). You gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(86,90),
                    Name = "1d3",
                    Description = "1d4+1 biological " +
                        "siblings. 1d3–1 of these siblings " +
                        "are half-elves, adopted, or a mix " +
                        "of the two (your choice). You gain " +
                        "access to the Kin Guardian combat " +
                        "trait. Roll on Table: " +
                        "Race Table to determine the " +
                        "race of any adopted siblings.",
                    //AlternateTable = typeof(RaceTable),
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.KinGuardian,
                    },
                },
                #endregion

                #region "No siblings"
                //91–100 No siblings    
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(91,100),
                    Name = "No siblings",
                    Description = "No siblings",
                },
                #endregion
            },
        };

        //Table: Random Height and Weight
        //Gender Base Height Height Modifier Base Weight Weight Modifier
        //Male	 5 ft. 4 in.    +2d8 in.      110 lbs.    +(2d8×3 lbs.)
        //Female 5 ft. 4 in.	+2d6 in.       90 lbs.    +(2d6×3 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
        private void SetHeightAndWeight()
        {
            if (Gender == GenderEnum.Male)
            {
                var modifier = new Dice("2d8").Total;
                if (modifier <= 7)
                {
                    //Height = $"5 ft. {4 + modifier} in.";
                }
                else if (modifier == 8)
                {
                    //Height = $"6 ft.";
                }
                else
                {
                    //Height = $"6 ft. {modifier - 9} in.";
                }
                // 110 lbs. +(2d8×3 lbs.)
                Weight = 110 + new Dice("2d8").Total * 3;
            }

            if (Gender == GenderEnum.Female)
            {
                var modifier = new Dice("2d6").Total;
                if (modifier <= 7)
                {
                    //Height = $"5 ft. {4 + modifier} in.";
                }
                else if (modifier == 8)
                {
                    //Height = $"6 ft.";
                }
                else
                {
                    //Height = $"6 ft. {modifier - 9} in.";
                }
                // 90 lbs. +(2d6×3 lbs.)
                Weight = 90 + new Dice("2d6").Total * 3;
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
        private void SetAge()
        {
        }
    }
}