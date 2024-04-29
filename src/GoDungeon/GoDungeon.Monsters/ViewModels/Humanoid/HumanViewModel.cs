using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
    /// <summary>
    /// As diverse as they are widespread, humans tend to grow up in small or large societies of people with similar origins and histories, though individuals’ paths may run the gamut from idealized to tragic.
    /// </summary>
    public class HumanViewModel : CharacterRaceViewModel, IHuman    
    {
        /// <summary>
        /// Set the race traits for the 
        /// </summary>
        public HumanViewModel(ILoggerFactory loggerFactory)
        {
            Initialize();
        }

        /// <summary>
        /// Initialize the creature
        /// </summary>
        public void Initialize()
        {
            Race = RaceEnum.Human;

            //Ability Score Modifiers: Human characters
            //gain a +1 racial bonus to every ability
            //score at creation to represent their
            //varied nature.
            Strength.RacialModifier += 1;
            Intelligence.RacialModifier += 1;
            Wisdom.RacialModifier += 1;
            Dexterity.RacialModifier += 1;
            Constitution.RacialModifier += 1;
            Charisma.RacialModifier += 1;

            //Size: Humans are Medium creatures and
            //thus receive no bonuses or penalties
            //due to their size.
            SetHeightAndWeight();
            SetAge();
            Size = SizeEnum.Medium;

            //Base Speed: Humans have a base speed of 30
            //feet.
            Speed = 30;

            //Type: Humans are humanoids with the
            //human subtype.
            RaceType = RaceType.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Human);

            //Languages: Humans begin play speaking
            //Common. 
            Languages.Add(LanguageEnum.Common);
        }

        //Table: Human Homeland
        //d%	Result
        //01–50	Town or Village You gain access to the Militia Veteran regional trait.
        //51–85	City or Metropolis If you’re a human, you gain access to the Civilized social trait and the Vagabond Child regional trait. If you’re a half-elf, you gain access to the Civilized social trait and the Failed Apprentice race trait. If you’re a half-orc, you gain access to the Brute race trait and the Vagabond Child regional trait.
        //86–95	Frontier You gain access to the Frontier-Forged regional trait.
        //96–100 Unusual Homeland.	Roll on Table: Unusual Homeland.
        /// <summary>
        /// The homeland table
        /// </summary>
        public static RandomTable HomelandTable { get; } = new()
        {
            DiceSides = 100,
            Table =
            [
                #region "Town or Village"
                //01–50	Town or Village You gain access
                //to the Militia Veteran regional trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01,50),
                    Name = "Town or Village",
                    Description =
                    "You gain access to the Militia Veteran regional trait.",
                    Traits =
                    {
                        TraitEnum.MilitiaVeteran,
                    },
                },
                #endregion

                #region "City or Metropolis"
                //51–85	City or Metropolis If you’re a
                //human, you gain access to the Civilized
                //social trait and the Vagabond Child
                //regional trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(51,85),
                    Name = "City or Metropolis",
                    Description = "If you’re a human, you gain access to the Civilized social trait and the Vagabond Child regional trait",
                    Traits =
                    {
                        TraitEnum.Civilized,
                        TraitEnum.VagabondChild,
                    },
                },
                #endregion

                #region "Frontier"
                //86–95	Frontier You gain access to the Frontier-Forged regional trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(86,95),
                    Name = "Frontier",
                    Description = "You gain access to the Frontier-Forged regional trait.",
                    Traits =
                    {
                        TraitEnum.FrontierForged,
                    },
                },
                #endregion
                        
                #region "Unusual Homeland."
                //96–100 Unusual Homeland.	Roll on Table:
                //Unusual Homeland.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(96,100),
                    Name = "Unusual Homeland",
                },
                #endregion
            ],
        };

        //Table: Human Parents
        //d%	Result
        //01–50	Both of your parents are alive.
        //51–70	Only your father is alive.
        //71–90	Only your mother is alive.
        //91–100	Both of your parents are dead. You gain access to the Orphaned social trait.
        /// <summary>
        /// The parents table
        /// </summary>
        private static RandomTable ParentsTable { get; } = new()
        {
            DiceSides = 100,
            Table =
            [
                #region "Both"
                //01–50	Both of your parents are alive.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01,50),
                    Name = "Both Alive",
                    Description = "Both of your parents are alive.",
                },
                #endregion

                #region "Father Only"
                //51–70	Only your father is alive.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(51,70),
                    Name = "Father Only",
                    Description = "Only your father is alive.",
                },
                #endregion

                #region "Mother Only"
                //71–90	Only your mother is alive.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(71,90),
                    Name = "Mother Only",
                    Description = "Only your mother is alive.",
                },
                #endregion

                #region "Both Dead"
                //91–100 Both of your parents are dead.
                //You gain access to the Orphaned social
                //trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(91,100),
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

        //Table: Human Siblings
        //d%	Result
        //01–40	1d2 siblings.With two siblings, you gain access to the Kin Guardian combat trait.
        //41–70	1d2 siblings and 1d2 half-siblings(roll d% to determine each one’s race; 01–50: half-elf, 51–100: half-orc). You gain access to the Kin Guardian combat trait.
        //71–90	2d4 siblings.You gain access to the Kin Guardian combat trait.
        //91–100	No siblings.
        /// <summary>
        /// The siblings table
        /// </summary>
        private static RandomTable SiblingsTable { get; } = new()
        {
            DiceSides = 100,
            Table =
            [
                #region "1d2"
                //01–40	1d2 siblings.With two siblings, you gain access to the Kin Guardian combat trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(01,40),
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

                #region "1d4"
                //41–70	1d2 siblings and 1d2 half-siblings(roll d% to determine each one’s race)
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(41,70),
                    Name = "1d4",
                    Description =
                        "1d2 siblings and 1d2 " +
                        "half-siblings (roll d% to " +
                        "determine each one’s race)",
                },
                #endregion

                #region "2d4"
                //71–90	2d4 siblings.You gain access to the Kin Guardian combat trait.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(71,90),
                    Name = "2d4",
                    Description =
                        "2d4 siblings.You gain access to " +
                        "the Kin Guardian combat trait.",
                    Traits =
                    {
                        TraitEnum.KinGuardian,
                    },
                },
                #endregion

                #region "No siblings"
                //91–100	No siblings.
                new BackgroundTableEntryViewModel
                {
                    Range = new Range(91,100),
                    Name = "No siblings",
                    Description = "No siblings",
                },
                #endregion
            ],
        };

        //Table: Random Height and Weight
        //Gender Base Height        Height Modifier Base Weight Weight Modifier
        //Male	    4 ft. 10 in.	+2d10 in.       120 lbs.    +(2d10×5 lbs.)
        //Female	4 ft. 5 in.	    +2d10 in.        85 lbs. +(2d10×5 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
        /// <param name="creature">The player character</param>
        private void SetHeightAndWeight()
        {
            if (Gender == GenderEnum.Male)
            {
                Height = new Height(4, 10).Add("2d10");

                // 120 lbs.    +(2d10×5 lbs.)
                Weight = 120 + new Dice("2d10").Total * 5;
            }

            if (Gender == GenderEnum.Female)
            {
                Height = new Height(4, 5).Add("2d10");

                // 85 lbs. +(2d10×5 lbs.)
                Weight = 85 + new Dice("2d10").Total * 5;
            }
        }

        //Table: Random Starting Ages
        //Adulthood   Intuitive1    Self-Taught2 Trained3
        //15 years	    +1d4 years  +1d6 years   +2d6 years
        //1 This category includes barbarians, oracles, rogues, and sorcerers.
        //2 This category includes bards, cavaliers, fighters, gunslingers, paladins, rangers, summoners, and witches.
        //3 This category includes alchemists, clerics, druids, inquisitors, magi, monks, and wizards.    
        /// <summary>
        /// Set the age
        /// </summary>
        /// <param name="creature"></param>
        private static void SetAge()
        {
        }
    }
}