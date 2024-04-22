// Ignore Spelling: Halfling

using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Character.Tables.Halfling;
using D20.Core;
using D20.Core.Enum;
using D20.Core.Models;

using Microsoft.Extensions.Logging;

namespace D20.Character.Race;

/// <summary>
/// Social and amicable by nature, halflings fit 
/// equally well in both communities of humans 
/// and those of their wily kinsfolk. Prone to 
/// wanderlust, halflings can be found anywhere 
/// civilized humanoids settle.
/// </summary>
public class Halfling : D20Character, ICharacterRace
{
    /// <summary>
    /// Constructor for a simple create
    /// </summary>
    [SetsRequiredMembers]
    public Halfling()
        : base()
    {
        Initialize();
    }

    /// <summary>
    /// Initialize the creature
    /// </summary>
    private void Initialize()
    {
        Race = RaceEnum.Halfling;

        //Ability Score Increase.Your Dexterity
        //score increases by 2.
        Dexterity.RacialModifier += 2;

        // Size. Your size is Small.
        SetHeightAndWeight();
        Age = 20;
        Size = SizeEnum.Small;

        // Speed. Your base walking speed is 25 feet.
        Speed = 25;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory"></param>
    /// <param name="services"></param>
    [SetsRequiredMembers]
    public Halfling(ILoggerFactory loggerFactory,
        IServiceProvider services)
        : base(loggerFactory)
    {
        // Initialize  the creature
        Initialize();

        // Now generate the characters background
        GenerateRaceBackground(services);
    }

    /// <summary>
    /// Generate the character background
    /// </summary>
    private void GenerateRaceBackground(IServiceProvider services)
    {
        #region Homeland
        var homelandTable = services.GetService<IHalflingHomelandTable>();
        homelandTable?.InitializeTable();
        Homeland = (IBackgroundTableEntry?) homelandTable?.GetRandomRangeEntry();
        if (Homeland?.Name == nameof(HalflingHomelandEnum.UnusualHomeland))
        {
            var unusualHomelandTable = services.GetService<IUnusualHomelandTable>();
            homelandTable?.InitializeTable();
            Homeland = (IBackgroundTableEntry?)unusualHomelandTable?.GetRandomRangeEntry();
        }
        if (Homeland?.Traits != null)
        {
            foreach (var trait in Homeland.Traits)
            {
                if (!Traits.Contains(trait))
                {
                    Traits.Add(trait);
                }
            }
        }
        #endregion

        #region Parents
        var parentsTable = services.GetService<IHalflingParentsTable>();
        parentsTable?.InitializeTable();
        Parents = (BackgroundTableEntry?)parentsTable?.GetRandomRangeEntry();
        if (Parents?.Traits != null)
        {
            foreach (var trait in Parents.Traits)
            {
                if (Traits.Contains(trait))
                {
                    Traits.Add(trait);
                }
            }
        }
        #endregion

        #region Circumstances of Birth
        var circumstanceofBirthTable = services.GetService<ICircumstanceofBirthTable>();
        circumstanceofBirthTable?.InitializeTable();
        CircumstanceOfBirth = (BackgroundTableEntry?)circumstanceofBirthTable?.GetRandomRangeEntry();
        if (CircumstanceOfBirth?.Traits != null)
        {
            foreach (var trait in CircumstanceOfBirth.Traits)
            {
                if (Traits.Contains(trait))
                {
                    Traits.Add(trait);
                }
            }
        }

        #endregion

        #region Siblings
        //var siblings = (BackgroundTableEntry?) siblingsTable.GetRandomRangeEntry();
        //if (siblings?.Name != "No siblings" && !string.IsNullOrEmpty(siblings?.Name))
        //{
        //    var total = new Dice(siblings.Name).Total;
        //    for (int i = 0; i < total; i++)
        //    {
        //        var creatureSiblings = new Halfling();

        //       // Set relative age of sibling
        //       var relativeAge = relativeAgeofSiblingTable.GetRandomRangeEntry();
        //        if (relativeAge?.Name == "Younger")
        //        {
        //            creatureSiblings.Age -= new Dice("1d4").Total;
        //        }
        //        if (relativeAge?.Name == "Older")
        //        {
        //            creatureSiblings.Age += new Dice("1d4").Total;
        //        }

        //        Siblings.Add(creatureSiblings);
        //    }
        //    if (Siblings.Count > 0)
        //    {
        //        if (!Traits.Contains(TraitEnum.KinGuardian))
        //        {
        //            Traits.Add(TraitEnum.KinGuardian);
        //        }
        //    }
        //}
        #endregion
    }

    //Table: Random Height and Weight
    //Gender Base Height    Height Modifier Base Weight Weight Modifier
    //Male	    2 ft. 8 in.	 +2d4 in.        30 lbs. +(2d4 lbs.)
    //Female	2 ft. 6 in.	 +2d4 in.        25 lbs. +(2d4 lbs.)
    /// <summary>
    /// The Height
    /// </summary>
    /// <param name="creature">The player character</param>
    public override void SetHeightAndWeight()
    {
        switch (Gender)
        {
            case GenderEnum.Male:
                Height = new Height(2, 8).Add("2d4");
                Weight = 30 + new Dice("2d4").Total;
                break;
            case GenderEnum.Female:
                Height = new Height(2, 6).Add("2d4");
                Weight = 25 + new Dice("2d4").Total;
                break;
        }
    }

    //Table: Random Starting Ages
    //Adulthood   Intuitive1 Self-Taught2 Trained3
    //20 years	 +2d4 years   +3d6 years   +4d6 years
    //1 This category includes barbarians, oracles, rogues, and sorcerers.
    //2 This category includes bards, cavaliers, fighters, gunslingers, paladins, rangers, summoners, and witches.
    //3 This category includes alchemists, clerics, druids, inquisitors, magi, monks, and wizards.
    /// <summary>
    /// Set the age
    /// </summary>
    /// <param name="creature"></param>
    public void SetAge(ICharacter creature)
    {
    }
}