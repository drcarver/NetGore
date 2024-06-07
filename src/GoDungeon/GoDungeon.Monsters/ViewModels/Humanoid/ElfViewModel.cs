using System;

using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;
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
        public ElfViewModel(
            IServiceProvider services,
            ILoggerFactory loggerFactory)
            : base(loggerFactory, services)
        {
            Initialize();
        }

        /// <summary>
        /// Initialize the character
        /// </summary>
        public void Initialize()
        {
            //Type: Elves are Humanoids with the elf subtype.
            Race = RaceEnum.Elf;
            RaceType = RaceTypeEnum.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Elf);

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
            Speed.Add(new MovementViewModel { Speed = 30, MovementType = MovementEnum.Normal });

            //Languages: Elves begin play speaking Common
            //and Elven .Elves with high Intelligence
            //scores can choose from the following:
            //Celestial, Draconic, Gnoll, Gnome, Goblin,
            //Orc, and Sylvan. See the Linguistics skill
            //page for more information about these
            //languages.
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Elven);
        }

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