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
            //Type: Half - orcs are Humanoid creatures
            //with both the human and orc subtypes.
            Race = RaceEnum.HalfOrc;
            RaceType = RaceType.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Human);
            RaceSubType.Add(RaceSubTypeEnum.Orc);

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

            //Languages: Half - orcs begin play speaking
            //Common and Orc. Half - orcs with high
            //Intelligence scores can choose from the
            //following: Abyssal, Draconic, Giant, Gnoll,
            //and Goblin.
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Orc);
        }

        //Table: Random Height and Weight
        //Gender    Base Height    Height Modifier Base Weight Weight Modifier
        //Male	    4 ft. 10 in.	+2d12 in.       150 lbs.    +(2d12×7 lbs.)
        //Female	4 ft. 5 in.	    +2d12 in.       110 lbs.    +(2d12×7 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
        /// <param name="creature">The player character</param>
        public override void SetHeightAndWeight()
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