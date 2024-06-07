using System;

using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;
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
        public HumanViewModel(
            IServiceProvider services, 
            ILoggerFactory loggerFactory) 
            : base(loggerFactory, services)
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
            Speed.Add(new MovementViewModel { Speed = 30, MovementType = MovementEnum.Normal });

            //Type: Humans are humanoids with the
            //human subtype.
            RaceType = RaceTypeEnum.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Human);

            //Languages: Humans begin play speaking
            //Common. 
            Languages.Add(LanguageEnum.Common);
        }

        //Table: Random Height and Weight
        //Gender Base Height        Height Modifier Base Weight Weight Modifier
        //Male	    4 ft. 10 in.	+2d10 in.       120 lbs.    +(2d10×5 lbs.)
        //Female	4 ft. 5 in.	    +2d10 in.        85 lbs.    +(2d10×5 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
        /// <param name="creature">The player character</param>
        public override void SetHeightAndWeight()
        {
            if (Gender == GenderEnum.Male)
            {
                Height = new HeightViewModel(4, 10).Add("2d10");

                // 120 lbs.    +(2d10×5 lbs.)
                Weight = 120 + new Dice("2d10").Total * 5;
            }

            if (Gender == GenderEnum.Female)
            {
                Height = new HeightViewModel(4, 5).Add("2d10");

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
