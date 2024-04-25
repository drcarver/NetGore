using System.Diagnostics.CodeAnalysis;

using D20.Background.Enum;
using D20.Background.Models;
using D20.Core;
using D20.Core.Enum;
using D20.Core.Models;
using D20.Monsters.Interfaces;
using D20.Monsters.Models;

using Microsoft.Extensions.Logging;

namespace NetGore.Data.Race;

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
public class Tiefling : CharacterRace, ICharacterRace
{
    /// <summary>
    /// Set the race traits for the 
    /// </summary>
    [SetsRequiredMembers]
    public Tiefling(ILoggerFactory loggerFactory)
        : base(loggerFactory)
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

    //Table: Tiefling Homeland
    //d%	Result
    //01–50	Town or Village You gain access to the Militia Veteran regional trait.
    //51–85	City or Metropolis If you’re a Tiefling,
    //      you gain access to the Civilized social
    //      trait and the Vagabond Child regional trait.
    //      If you’re a half-elf, you gain access to
    //      the Civilized social trait and the Failed
    //      Apprentice race trait. If you’re a half-orc,
    //      you gain access to the Brute race trait and
    //      the Vagabond Child regional trait.
    //86–95	Frontier You gain access to the Frontier-Forged
    //      regional trait.
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
            new BackgroundTableEntry
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
            new BackgroundTableEntry
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
            new BackgroundTableEntry
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
            new BackgroundTableEntry
            {
                Range = new Range(96,100),
                Name = "Unusual Homeland",
            },
            #endregion
        ],
    };

    //Table: Tiefling Parents
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
            new BackgroundTableEntry
            {
                Range = new Range(01,50),
                Name = "Both Alive",
                Description = "Both of your parents are alive.",
            },
            #endregion

            #region "Father Only"
            //51–70	Only your father is alive.
            new BackgroundTableEntry
            {
                Range = new Range(51,70),
                Name = "Father Only",
                Description = "Only your father is alive.",
            },
            #endregion

            #region "Mother Only"
            //71–90	Only your mother is alive.
            new BackgroundTableEntry
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
            new BackgroundTableEntry
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

    //Table: Tiefling Siblings
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
            new BackgroundTableEntry
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
            new BackgroundTableEntry
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
            new BackgroundTableEntry
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
            new BackgroundTableEntry
            {
                Range = new Range(91,100),
                Name = "No siblings",
                Description = "No siblings",
            },
            #endregion
        ],
    };

    //Random Tiefling Height and Weight
    //Gender  Base Height Height Modifier Base Weight Weight Modifier
    //Male	    4 ft. 10 in.	+2d10 in.   120 lbs.    +(2d10×5 lbs.)
    //Female	4 ft. 5 in.	    +2d10 in.    85 lbs.    +(2d10×5 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    private void SetHeightAndWeight()
    {
        if (Gender == GenderEnum.Male)
        {
            Height = new Height(4, 10).Add("2d10");

            // 120 lbs.    +(2d10×5 lbs.)
            Weight = 120 + (new Dice("2d10").Total * 5);
        }

        if (Gender == GenderEnum.Female)
        {
            Height = new Height(4, 5).Add("2d10");

            // 85 lbs. +(2d10×5 lbs.)
            Weight = 85 + (new Dice("2d10").Total * 5);
        }
    }

    //Random Tiefling Starting Ages
    //Adulthood Intuitive1  Self-Taught2 Trained3
    //60 years	+4d6 years  +6d6 years   +8d6 years
    /// <summary>
    /// Set the age
    /// </summary>
    /// <param name="creature"></param>
    private void SetAge()
    {
    }
}