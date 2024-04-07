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

using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Data.Background;

/// <summary>
/// The table of races
/// </summary>
public class RaceTable : GameTable, IRaceTable
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
    [SetsRequiredMembers]
    public RaceTable()
    {
        Name = nameof(RaceTable);
        ProperName = "Race Table";
        DiceSides = 100;
        Table =
        [
            #region "Aasimar"
            //01	Aasimar
            new GameTableEntry
            {
                Range = new Range(01, 01),
                Name = nameof(RaceEnum.Aasimar),
            },
            #endregion

            #region "Catfolk"
            //02	Catfolk
            new GameTableEntry
            {
                Range = new Range(02, 02),
                Name = nameof(RaceEnum.Catfolk),
            },
            #endregion

            #region "Changeling"
            //03–04	Changeling
            new GameTableEntry
            {
                Range = new Range(03, 04),
                Name = nameof(RaceEnum.Changeling),
            },
            #endregion

            #region "Dhampir"
            //05	Dhampir
            new GameTableEntry
            {
                Range = new Range(05, 05),
                Name = nameof(RaceEnum.Dhampir),
            },
            #endregion

            #region "Duergar"
            //06	Duergar
            new GameTableEntry
            {
                Range = new Range(06, 06),
                Name = nameof(RaceEnum.Duergar),
            },
            #endregion

            #region "Dwarf"
            //07–16	Dwarf
            new GameTableEntry
            {
                Range = new Range(07, 16),
                Name = nameof(RaceEnum.Dwarf),
            },
            #endregion

            #region "Elf"
            //17–26	Elf
            new GameTableEntry
            {
                Range = new Range(17, 26),
                Name = nameof(RaceEnum.Elf),
            },
            #endregion

            #region "Fetchling"
            //27	Fetchling
            new GameTableEntry
            {
                Range = new Range(27, 27),
                Name = nameof(RaceEnum.Fetchling),
            },
            #endregion

            #region "Gillman"
            //28	Gillman
            new GameTableEntry
            {
                Range = new Range(28, 28),
                Name = nameof(RaceEnum.Gillman),
            },
            #endregion

            #region "Gnome"
            //29–38	Gnome
            new GameTableEntry
            {
                Range = new Range(29, 38),
                Name = nameof(RaceEnum.Gnome),
            },
            #endregion

            #region "Goblin"
            //39	Goblin
            new GameTableEntry
            {
                Range = new Range(39, 39),
                Name = nameof(RaceEnum.Goblin),
            },
            #endregion

            #region "Grippli"
            //40	Grippli
            new GameTableEntry
            {
                Range = new Range(40, 40),
                Name = nameof(RaceEnum.Grippli),
            },
            #endregion

            #region "Half-Elf"
            //41–50	Half-Elf
            new GameTableEntry
            {
                Range = new Range(41, 50),
                Name = nameof(RaceEnum.HalfElf),
                ProperName = "Half-Elf"
            },
            #endregion

            #region "Half-orc"
            //51–60	Half-orc
            new GameTableEntry
            {
                Range = new Range(51, 60),
                Name = nameof(RaceEnum.HalfOrc),
                ProperName = "Half-orc"
            },
            #endregion

            #region "Halfling"
            //61–70	Halfling
            new GameTableEntry
            {
                Range = new Range(61, 70),
                Name = nameof(RaceEnum.Halfling),
            },
            #endregion

            #region "Hobgoblin"
            //71	Hobgoblin
            new GameTableEntry
            {
                Range = new Range(71, 71),
                Name = nameof(RaceEnum.Hobgoblin),
            },
            #endregion

            #region "Human"
            //72–81	Human
            new GameTableEntry
            {
                Range = new Range(72, 81),
                Name = nameof(RaceEnum.Human),
            },
            #endregion

            #region "Ifrit"
            //82	Ifrit
            new GameTableEntry
            {
                Range = new Range(82, 82),
                Name = nameof(RaceEnum.Ifrit),
            },
            #endregion

            #region "Kitsune"
            //83	Kitsune
            new GameTableEntry
            {
                Range = new Range(83, 83),
                Name = nameof(RaceEnum.Kitsune),
            },
            #endregion

            #region "Kobold"
            //84	Kobold
            new GameTableEntry
            {
                Range = new Range(84, 84),
                Name = nameof(RaceEnum.Kobold),
            },
            #endregion

            #region "Merfolk"
            //85	Merfolk
            new GameTableEntry
            {
                Range = new Range(85, 85),
                Name = nameof(RaceEnum.Merfolk),
            },
            #endregion

            #region "Nagaji"
            //86	Nagaji
            new GameTableEntry
            {
                Range = new Range(86, 86),
                Name = nameof(RaceEnum.Nagaji),
            },
            #endregion

            #region "Orc"
            //87	Orc
            new GameTableEntry
            {
                Range = new Range(87, 87),
                Name = nameof(RaceEnum.Orc),
            },
            #endregion

            #region "Oread"
            //88	Oread
            new GameTableEntry
            {
                Range = new Range(88, 88),
                Name = nameof(RaceEnum.Oread),
            },
            #endregion

            #region "Ratfolk"
            //89	Ratfolk
            new GameTableEntry
            {
                Range = new Range(89, 89),
                Name = nameof(RaceEnum.Ratfolk),
            },
            #endregion

            #region "Samsaran"
            //90	Samsaran
            new GameTableEntry
            {
                Range = new Range(90, 90),
                Name = nameof(RaceEnum.Samsaran),
            },
            #endregion

            #region "Strix"
            //91	Strix
            new GameTableEntry
            {
                Range = new Range(91, 91),
                Name = nameof(RaceEnum.Strix),
            },
            #endregion

            #region "Suli"
            //92	Suli
            new GameTableEntry
            {
                Range = new Range(92, 92),
                Name = nameof(RaceEnum.Suli),
            },
            #endregion

            #region "Svirfneblin"
            //93	Svirfneblin
            new GameTableEntry
            {
                Range = new Range(93, 93),
                Name = nameof(RaceEnum.Svirfneblin),
            },
            #endregion

            #region "Sylph"
            //94	Sylph
            new GameTableEntry
            {
                Range = new Range(94, 94),
                Name = nameof(RaceEnum.Sylph),
            },
            #endregion

            #region "Tengu"
            //95	Tengu
            new GameTableEntry
            {
                Range = new Range(95, 95),
                Name = nameof(RaceEnum.Tengu),
            },
            #endregion

            #region "Tiefling"
            //96	Tiefling
            new GameTableEntry
            {
                Range = new Range(96, 96),
                Name = nameof(RaceEnum.Tiefling),
            },
            #endregion

            #region "Undine"
            //97	Undine
            new GameTableEntry
            {
                Range = new Range(97, 97),
                Name = nameof(RaceEnum.Undine),
            },
            #endregion

            #region "Vanara"
            //98	Vanara
            new GameTableEntry
            {
                Range = new Range(98, 98),
                Name = nameof(RaceEnum.Vanara),
            },
            #endregion

            #region "Vishkanya"
            //99	Vishkanya
            new GameTableEntry
            {
                Range = new Range(99, 99),
                Name = nameof(RaceEnum.Vishkanya),
            },
            #endregion

            #region "Wayang"
            //100	Wayang
            new GameTableEntry
            {
                Range = new Range( 100,100),
                Name = nameof(RaceEnum.Wayang),
            },
            #endregion
        ];
    }
}
