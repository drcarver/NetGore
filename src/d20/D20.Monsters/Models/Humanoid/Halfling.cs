using System.Diagnostics.CodeAnalysis;

using D20.Background.Interfaces;
using D20.Background.Tables.Halfling;
using D20.Core;
using D20.Core.Enum;
using D20.Core.Models;
using D20.Monsters.Race;

using Microsoft.Extensions.Logging;

namespace D20.Monsters.Models.Humanoid;

/// <summary>
/// Social and amicable by nature, halflings fit 
/// equally well in both communities of humans 
/// and those of their wily kinsfolk. Prone to 
/// wanderlust, halflings can be found anywhere 
/// civilized humanoids settle.
/// </summary>
public class Halfling : CharacterRace, IHalfling
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory"></param>
    /// <param name="services"></param>
    [SetsRequiredMembers]
    public Halfling(
        ILoggerFactory loggerFactory,
        IHalflingHomelandTable homelandTable,
        IUnusualHomelandTable unusualHomelandTable,
        IHalflingParentsTable parentsTable,
        ICircumstanceofBirthTable circumstanceofBirthTable,
        IProfessionTable professionTable,
        INobilityTable nobilityTable,
        IAdoptedOutsideYourRaceTable adoptedOutsideYourRaceTable
        ) : base(loggerFactory)
    {
        // Initialize  the character from the race features
        Initialize();

        // Now generate the characters background
        GetHomeland(homelandTable, unusualHomelandTable);
        GetParents(parentsTable);
        GetCircumstanceofBirth(
            circumstanceofBirthTable,
            professionTable,
            nobilityTable,
            adoptedOutsideYourRaceTable);
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
    /// Generate the character background
    /// </summary>
    private void GenerateRaceBackground(IServiceProvider services)
    {
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
}