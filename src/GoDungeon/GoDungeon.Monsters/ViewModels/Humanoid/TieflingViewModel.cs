using GoDungeon.Core;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels.Humanoid
{
    /// <summary>
    /// Simultaneously more and less than mortal, 
    /// tieflings are the offspring of humans and 
    /// fiends. With otherworldly blood and traits 
    /// to match, tieflings are often shunned and 
    /// despised out of reactionary fear. Most 
    /// tieflings never know their fiendish sire, 
    /// as the coupling that produced their curse 
    /// occurred generations earlier. The taint is 
    /// long-lasting and persistent, often manifesting 
    /// at birth or sometimes later in life, as a 
    /// powerful, though often unwanted, boon. Despite 
    /// their fiendish appearance and netherworld 
    /// origins, tieflings have a human’s capacity 
    /// of choosing their fate, and while many 
    /// embrace their dark heritage and side with 
    /// fiendish powers, others reject their darker 
    /// predilections. Though the power of their 
    /// blood calls nearly every tiefling to fury, 
    /// destruction, and wrath, even the spawn of a 
    /// succubus can become a saint and the 
    /// grandchild of a pit fiend an unsuspecting hero.
    /// </summary>
    public class TieflingViewModel : CharacterRaceViewModel, ITiefling
    {
        /// <summary>
        /// Set the race traits for the 
        /// </summary>
        public TieflingViewModel(ILoggerFactory loggerFactory)
        {
            Initialize();
        }

        /// <summary>
        /// Initialize the creature
        /// </summary>
        public void Initialize()
        {
            Race = RaceEnum.Tiefling;

            //Ability Score Modifiers: Tieflings are quick
            //in body and mind, but are inherently strange
            //and unnerving. They gain +2 Dexterity,
            //+2 Intelligence, and –2 Charisma.
            Intelligence.RacialModifier = 2;
            Dexterity.RacialModifier = 2;
            Charisma.RacialModifier = -2;

            //Type: Tieflings are outsiders with the
            //native subtype.
            RaceType = RaceType.Outsiders;
            RaceSubType.Add(RaceSubTypeEnum.Native);

            //Size: Tieflings are Medium creatures and
            //thus receive no bonuses or penalties due
            //to their size.
            Size = SizeEnum.Medium;

            // Set the height and weight
            SetHeightAndWeight();

            //Speed: Tieflings have a base speed of 30 feet.
            Speed = 30;

            //Languages: Tieflings begin play speaking
            //Common and either Abyssal or Infernal.
            //Tieflings with high intelligence scores
            //can choose from the following: Abyssal,
            //Draconic, Dwarven, Elven, Gnome, Goblin,
            //Halfling, Infernal, and Orc. See the
            //Linguistics skill page for more information
            //about these languages.
            Languages.Add(LanguageEnum.Common);
            Languages.Add(LanguageEnum.Abyssal);
            Languages.Add(LanguageEnum.Infernal);
        }

        //Random Tiefling Height and Weight
        //Gender  Base Height Height Modifier Base Weight Weight Modifier
        //Male	    4 ft. 10 in.	+2d10 in.   120 lbs.    +(2d10×5 lbs.)
        //Female	4 ft. 5 in.	    +2d10 in.    85 lbs.    +(2d10×5 lbs.)
        /// <summary>
        /// The Height
        /// </summary>
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
    }
}