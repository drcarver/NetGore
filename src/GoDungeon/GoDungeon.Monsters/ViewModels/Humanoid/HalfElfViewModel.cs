using System;

using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
    /// <summary>
    /// The capricious and carefree gnomes of the world 
    /// are widespread and varied. They typically either 
    /// form their own gnome communities or integrate 
    /// themselves into other humanoid societies.
    /// </summary>
    public class HalfElfViewModel : CharacterRaceViewModel, IHalfElf
    {
        /// <summary>
        /// Set the race traits for the creature.
        /// </summary>
        public HalfElfViewModel(
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
            //Type: HalfElf are Humanoid creatures with the HalfElf subtype.
            Race = RaceEnum.HalfElf;
            RaceType = RaceTypeEnum.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.HalfElf);

            //Ability Score Increase. Your Charisma
            //score increases by 2, and two other
            //ability scores of your choice increase
            //by 1.
            Charisma.RacialModifier += 2;
            Intelligence.RacialModifier += 1;
            Dexterity.RacialModifier += 1;

            // Size. Elves stand between 4 and 5 feet tall
            // and average about 150 pounds. Your size is Medium.
            SetHeightAndWeight();
            Size = SizeEnum.Medium;

            // Speed.Your base walking speed is 25 feet.
            // Your speed is not reduced by wearing
            // heavy armor
            Speed.Add(new MovementViewModel { Speed = 30, MovementType = MovementEnum.Normal });
        }

        //Table: Random Height and Weight
        //Gender Base Height   Height Modifier Base Weight Weight Modifier
        //Male	 5 ft. 2 in.	+2d8 in.        100 lbs.    +(2d8×5 lbs.)
        //Female 5 ft. 0 in.	+2d8 in.         90 lbs.    +(2d8×5 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
        /// <param name="creature">The player character</param>
        private static void SetHeightAndWeight(ICharacter creature)
        {
            if (creature?.Gender == GenderEnum.Male)
            {
                var modifier = new Dice("2d8").Total;
                if (modifier <= 9)
                {
                    //creature.Height = $"5 ft. {modifier + 2} in.";
                }
                else if (modifier == 10)
                {
                    //creature.Height = $"6 ft.";
                }
                else
                {
                    //creature.Height = $"6 ft. {modifier - 10} in.";
                }
                // 100 lbs. +(2d8×5 lbs.)
                creature.Weight = 100 + new Dice("2d8").Total * 5;
            }

            if (creature?.Gender == GenderEnum.Female)
            {
                var modifier = new Dice("2d8").Total;
                if (modifier <= 11)
                {
                    //creature.Height = $"5 ft. {modifier} in.";
                }
                else if (modifier == 12)
                {
                    //creature.Height = $"6 ft.";
                }
                else
                {
                    //creature.Height = $"6 ft. {modifier - 12} in.";
                }
                // 90 lbs. +(2d8×5 lbs.)
                creature.Weight = 90 + new Dice("2d8").Total * 5;
            }
        }
    }
}