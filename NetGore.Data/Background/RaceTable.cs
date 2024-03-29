#region Copyright Notice and source url
//
// This content contains copyright material. The material
// format has been change to support the needs of the
// Application.  In particular the table entries and
// values have the following copyright notice.
//
// The content is from the url:
// https://www.d20pfsrd.com/basics-ability-scores/more-character-options/character-backgrounds/background-generator
//
// Pathfinder Roleplaying Game: Ultimate Campaign.
// ©2013, Paizo Publishing, LLC;
// Authors: Jesse Benner, Benjamin Bruck, Jason Bulmahn,
// Ryan Costello, Adam Daigle, Matt Goetz, Tim Hitchcock,
// James Jacobs, Ryan Macklin, Colin McComb,
// Jason Nelson, Richard Pett, Stephen Radney-MacFarland,
// Patrick Renie, Sean K Reynolds, F. Wesley Schneider,
// James L.Sutter, Russ Taylor, and Stephen Townshend.
//
#endregion

using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// The table of races
/// </summary>
public partial class BackgroundTables
{
    //Table: Race
    //d%	Result
    //01	Aasimar
    //02	Catfolk
    //03–04	Changeling
    //05	Dhampir
    //06	Duergar
    //07–16	Dwarf
    //17–26	Elf
    //27	Fetchling
    //28	Gillman
    //29–38	Gnome
    //39	Goblin
    //40	Grippli
    //41–50	Half-Elf
    //51–60	Half-orc
    //61–70	Halfling
    //71	Hobgoblin
    //72–81	Human
    //82	Ifrit
    //83	Kitsune
    //84	Kobold
    //85	Merfolk
    //86	Nagaji
    //87	Orc
    //88	Oread
    //89	Ratfolk
    //90	Samsaran
    //91	Strix
    //92	Suli
    //93	Svirfneblin
    //94	Sylph
    //95	Tengu
    //96	Tiefling
    //97	Undine
    //98	Vanara
    //99	Vishkanya
    //100	Wayang
    /// <summary>
    /// Allowed character races
    /// </summary>
    public static RandomTable RaceTable { get; } = new()
    {
        Name = "Race Table",
        DiceSides = 100,
        Table =
        [
            #region "Aasimar"
            //01	Aasimar
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 01,
                Name = nameof(RaceEnum.Aasimar),
            },
            #endregion

            #region "Catfolk"
            //02	Catfolk
            new RandomTableEntry
            {
                LowerRange = 02,
                UpperRange = 02,
                Name = nameof(RaceEnum.Catfolk),
            },
            #endregion

            #region "Changeling"
            //03–04	Changeling
            new RandomTableEntry
            {
                LowerRange = 03,
                UpperRange = 04,
                Name = nameof(RaceEnum.Changeling),
            },
            #endregion

            #region "Dhampir"
            //05	Dhampir
            new RandomTableEntry
            {
                LowerRange = 05,
                UpperRange = 05,
                Name = nameof(RaceEnum.Dhampir),
            },
            #endregion

            #region "Duergar"
            //06	Duergar
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 06,
                Name = nameof(RaceEnum.Duergar),
            },
            #endregion

            #region "Dwarf"
            //07–16	Dwarf
            new RandomTableEntry
            {
                LowerRange = 07,
                UpperRange = 16,
                Name = nameof(RaceEnum.Dwarf),
            },
            #endregion

            #region "Elf"
            //17–26	Elf
            new RandomTableEntry
            {
                LowerRange = 17,
                UpperRange = 26,
                Name = nameof(RaceEnum.Elf),
            },
            #endregion

            #region "Fetchling"
            //27	Fetchling
            new RandomTableEntry
            {
                LowerRange = 27,
                UpperRange = 27,
                Name = nameof(RaceEnum.Fetchling),
            },
            #endregion

            #region "Gillman"
            //28	Gillman
            new RandomTableEntry
            {
                LowerRange = 28,
                UpperRange = 28,
                Name = nameof(RaceEnum.Gillman),
            },
            #endregion

            #region "Gnome"
            //29–38	Gnome
            new RandomTableEntry
            {
                LowerRange = 29,
                UpperRange = 38,
                Name = nameof(RaceEnum.Gnome),
            },
            #endregion

            #region "Goblin"
            //39	Goblin
            new RandomTableEntry
            {
                LowerRange = 39,
                UpperRange = 39,
                Name = nameof(RaceEnum.Goblin),
            },
            #endregion

            #region "Grippli"
            //40	Grippli
            new RandomTableEntry
            {
                LowerRange = 40,
                UpperRange = 40,
                Name = nameof(RaceEnum.Grippli),
            },
            #endregion

            #region "Half-Elf"
            //41–50	Half-Elf
            new RandomTableEntry
            {
                LowerRange = 41,
                UpperRange = 50,
                Name = nameof(RaceEnum.HalfElf),
                ProperName = "Half-Elf"
            },
            #endregion

            #region "Half-orc"
            //51–60	Half-orc
            new RandomTableEntry
            {
                LowerRange = 51,
                UpperRange = 60,
                Name = nameof(RaceEnum.HalfOrc),
                ProperName = "Half-orc"
            },
            #endregion

            #region "Halfling"
            //61–70	Halfling
            new RandomTableEntry
            {
                LowerRange = 61,
                UpperRange = 70,
                Name = nameof(RaceEnum.Halfling),
            },
            #endregion

            #region "Hobgoblin"
            //71	Hobgoblin
            new RandomTableEntry
            {
                LowerRange = 71,
                UpperRange = 71,
                Name = nameof(RaceEnum.Hobgoblin),
            },
            #endregion

            #region "Human"
            //72–81	Human
            new RandomTableEntry
            {
                LowerRange = 72,
                UpperRange = 81,
                Name = nameof(RaceEnum.Human),
            },
            #endregion

            #region "Ifrit"
            //82	Ifrit
            new RandomTableEntry
            {
                LowerRange = 82,
                UpperRange = 82,
                Name = nameof(RaceEnum.Ifrit),
            },
            #endregion

            #region "Kitsune"
            //83	Kitsune
            new RandomTableEntry
            {
                LowerRange = 83,
                UpperRange = 83,
                Name = nameof(RaceEnum.Kitsune),
            },
            #endregion

            #region "Kobold"
            //84	Kobold
            new RandomTableEntry
            {
                LowerRange = 84,
                UpperRange = 84,
                Name = nameof(RaceEnum.Kobold),
            },
            #endregion

            #region "Merfolk"
            //85	Merfolk
            new RandomTableEntry
            {
                LowerRange = 85,
                UpperRange = 85,
                Name = nameof(RaceEnum.Merfolk),
            },
            #endregion

            #region "Nagaji"
            //86	Nagaji
            new RandomTableEntry
            {
                LowerRange = 86,
                UpperRange = 86,
                Name = nameof(RaceEnum.Nagaji),
            },
            #endregion

            #region "Orc"
            //87	Orc
            new RandomTableEntry
            {
                LowerRange = 87,
                UpperRange = 87,
                Name = nameof(RaceEnum.Orc),
            },
            #endregion

            #region "Oread"
            //88	Oread
            new RandomTableEntry
            {
                LowerRange = 88,
                UpperRange = 88,
                Name = nameof(RaceEnum.Oread),
            },
            #endregion

            #region "Ratfolk"
            //89	Ratfolk
            new RandomTableEntry
            {
                LowerRange = 89,
                UpperRange = 89,
                Name = nameof(RaceEnum.Ratfolk),
            },
            #endregion

            #region "Samsaran"
            //90	Samsaran
            new RandomTableEntry
            {
                LowerRange = 90,
                UpperRange = 90,
                Name = nameof(RaceEnum.Samsaran),
            },
            #endregion

            #region "Strix"
            //91	Strix
            new RandomTableEntry
            {
                LowerRange = 91,
                UpperRange = 91,
                Name = nameof(RaceEnum.Strix),
            },
            #endregion

            #region "Suli"
            //92	Suli
            new RandomTableEntry
            {
                LowerRange = 92,
                UpperRange = 92,
                Name = nameof(RaceEnum.Suli),
            },
            #endregion

            #region "Svirfneblin"
            //93	Svirfneblin
            new RandomTableEntry
            {
                LowerRange = 93,
                UpperRange = 93,
                Name = nameof(RaceEnum.Svirfneblin),
            },
            #endregion

            #region "Sylph"
            //94	Sylph
            new RandomTableEntry
            {
                LowerRange = 94,
                UpperRange = 94,
                Name = nameof(RaceEnum.Sylph),
            },
            #endregion

            #region "Tengu"
            //95	Tengu
            new RandomTableEntry
            {
                LowerRange = 95,
                UpperRange = 95,
                Name = nameof(RaceEnum.Tengu),
            },
            #endregion

            #region "Tiefling"
            //96	Tiefling
            new RandomTableEntry
            {
                LowerRange = 96,
                UpperRange = 96,
                Name = nameof(RaceEnum.Tiefling),
            },
            #endregion

            #region "Undine"
            //97	Undine
            new RandomTableEntry
            {
                LowerRange = 97,
                UpperRange = 97,
                Name = nameof(RaceEnum.Undine),
            },
            #endregion

            #region "Vanara"
            //98	Vanara
            new RandomTableEntry
            {
                LowerRange = 98,
                UpperRange = 98,
                Name = nameof(RaceEnum.Vanara),
            },
            #endregion

            #region "Vishkanya"
            //99	Vishkanya
            new RandomTableEntry
            {
                LowerRange = 99,
                UpperRange = 99,
                Name = nameof(RaceEnum.Vishkanya),
            },
            #endregion

            #region "Wayang"
            //100	Wayang
            new RandomTableEntry
            {
                LowerRange = 100,
                UpperRange = 100,
                Name = nameof(RaceEnum.Wayang),
            },
            #endregion
        ]
    };
}
