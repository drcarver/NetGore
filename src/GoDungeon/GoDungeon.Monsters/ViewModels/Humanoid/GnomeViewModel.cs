using System;

using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
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
        public GnomeViewModel(
            IServiceProvider services,
            ILoggerFactory loggerFactory)
            : base(loggerFactory, services)
        {
            Initialize();
        }

        /// <summary>
        /// Initialize all the race properties of the character
        /// </summary>
        public void Initialize()
        {
            //Type: Gnomes are Humanoid creatures with the gnome subtype.
            Race = RaceEnum.Gnome;
            RaceType = RaceType.Humanoid;
            RaceSubType.Add(RaceSubTypeEnum.Gnome);

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

            //Languages: Gnomes begin play speaking
            //Common, Gnome, and Sylvan. Gnomes with
            //high Intelligence scores can choose from
            //the following: Draconic, Dwarven, Elven,
            //Giant, Goblin, and Orc.
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Gnome);
            Languages.Add(LanguageEnum.Sylvan);
        }

        //Table: Random Height and Weight
        //Gender Base Height Height Modifier Base Weight Weight Modifier
        //Male	 3 ft. 0 in.	+2d4 in.  35 lbs. +(2d4 lbs.)
        //Female 2 ft. 10 in.	+2d4 in.  30 lbs. +(2d4 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
        /// <param name="creature">The dwarf</param>
        public override void SetHeightAndWeight()
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