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
    /// The capricious and carefree gnomes of the 
    /// world are widespread and varied. They 
    /// typically either form their own gnome 
    /// communities or integrate themselves into 
    /// other humanoid societies.
    /// </summary>
    public class GnomeViewModel : CharacterRaceViewModel, IGnome
    {
        /// <summary>
        /// Set the race traits for the creature.
        /// </summary>
        public GnomeViewModel(ILoggerFactory loggerFactory)
        {
            Initialize();
        }

        /// <summary>
        /// Initialize all the race properties of the character
        /// </summary>
        public void Initialize()
        {
            Race = RaceEnum.Gnome;

            //Ability Score Increase.Your Intelligence
            //score increases by 2.
            Intelligence.RacialModifier = 2;

            //Size: Gnomes are Small creatures and
            //thus gain a +1 size bonus to their
            //AC, a + 1 size bonus on attack rolls,
            //a –1 penalty to their Combat Maneuver
            //Bonus and Combat Maneuver Defense,
            //and a + 4 size bonus on Stealth checks.
            SetHeightAndWeight();
            Size = SizeEnum.Small;

            //Base Speed: (Slow Speed) Gnomes have a
            //base speed of 20 feet.
            Speed = 20;

            //Type: Gnomes are Humanoid creatures with
            //the gnome subtype.
            RaceType = RaceType.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Gnome);

            //Languages: Gnomes begin play speaking
            //Common, Gnome, and Sylvan. Gnomes with
            //high Intelligence scores can choose from
            //the following: Draconic, Dwarven, Elven,
            //Giant, Goblin, and Orc.
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Gnomish);
            Languages.Add(LanguageEnum.Sylvan);
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
        private static RandomTable HomelandTable { get; set; } = new RandomTable
        {
            DiceSides = 100,
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region "Forest"
                //01–30	Forest You gain access to the
                //Log Roller regional trait and the
                //Animal Friend race trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01, 30),
                    Name = "Forest",
                    Description =
                        "You gain access to the " +
                        "Log Roller regional trait and " +
                        "the Animal Friend race trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.AnimalFriend
                    },
                },
                #endregion

                #region "Non-Gnome Town or Village"
                //31–65	Non-Gnome Town or Village   You gain access to the Animal Friend race trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(31, 65),
                    Name = "Non-Gnome Town or Village",
                    Description =
                        "You gain access to the Animal Friend race trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.AnimalFriend,
                    },
                },
                #endregion

                #region "Non-Gnome City or Metropolis"
                //66–95	Non-Gnome City or Metropolis You gain access to the Rapscallion race trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(66, 95),
                    Name = "Non-Gnome City or Metropolis",
                    Description =
                        "You gain access to the Rapscallion race trait.",
                    Traits = new ObservableCollection<TraitEnum> 
                    {
                        TraitEnum.Rapscallion,
                    },
                },
                #endregion

                #region "Unusual Homeland."
                //96–100 Unusual Homeland.	Roll on Table:
                //Unusual Homeland.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(96, 100),
                    Name = "Unusual Homeland",
                },
                #endregion
            },
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
        private static RandomTable ParentsTable { get; set; } = new RandomTable
        {
            DiceSides = 100,
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region "Both"
                //01–90	Both of your parents are alive.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01,90),
                    Name = "Both Alive",
                    Description = "Both of your parents are alive.",
                },
                #endregion

                #region "Father Only"
                //91–93	Only your father is alive.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(91,93),
                    Name = "Father Only",
                    Description = "Only your father is alive.",
                },
                #endregion

                #region "Mother Only"
                //94–96	Only your mother is alive.
                new BackgroundTableEntryViewModel
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
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(97,100),
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

        //Table: Gnome Siblings
        //d%	Result
        //01–50	1d4 biological siblings.With two or more siblings, you gain access to the Kin Guardian combat trait.
        //51–60	1d4–1 biological siblings and one adopted sibling. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
        //61–100	No siblings.
        /// <summary>
        /// The siblings table
        /// </summary>
        private static RandomTable SiblingsTable { get; set; } = new RandomTable
        {
            DiceSides = 100,
            Table = new ObservableCollection<IGameTableEntry>
            {
                #region "1d4"
                //01–50	1d4 biological siblings.With two or more siblings, you gain access to the Kin Guardian combat trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01,50),
                    Name = "1d4",
                    Description =
                        "With two or more siblings, you " +
                        "gain access to the Kin Guardian " +
                        "combat trait.",
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.KinGuardian,
                    },
                },
                #endregion

                #region "1d4-1"
                //51–60	1d4–1 biological siblings and one adopted sibling. With two or more siblings, you gain access to the Kin Guardian combat trait.Roll on Table: Race of Adopted Sibling to determine the race of any adopted siblings.
                new BackgroundTableEntryViewModel
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
                    Traits = new ObservableCollection<TraitEnum>
                    {
                        TraitEnum.KinGuardian,
                    },
                },
                #endregion

                #region "No siblings"
                //61–100	No siblings.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(61,100),
                    Name = "No siblings",
                    Description = "No siblings",
                },
                #endregion
            },
        };

        //Table: Random Height and Weight
        //Gender Base Height Height Modifier Base Weight Weight Modifier
        //Male	 3 ft. 0 in.	+2d4 in.  35 lbs. +(2d4 lbs.)
        //Female 2 ft. 10 in.	+2d4 in.  30 lbs. +(2d4 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
        /// <param name="creature">The dwarf</param>
        private void SetHeightAndWeight()
        {
            if (Gender == GenderEnum.Male)
            {
                // 3 ft. 0 in.	+2d4 in.
                //creature.Height = $"3 ft. {new Dice("2d8").Total} in.";

                // 35 lbs. +(2d4 lbs.)
                //creature.Weight = 35 + new Dice("2d4").Total;
            }

            // Female 2 ft. 10 in.	+2d4 in.
            if (Gender == GenderEnum.Female)
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
                Weight = 30 + new Dice("2d4").Total;
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
    }
}