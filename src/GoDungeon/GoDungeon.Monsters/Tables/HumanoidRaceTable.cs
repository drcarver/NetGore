#region Copyright Notice and source url
//
// This content contains copyright material. The material
// format has been change to support the needs of the
// Application.  In particular the table entries and
// values have the following copyright notice.
//
// The content is from the url:
// https://www.GoDungeonpfsrd.com/basics-ability-scores/more-character-options/character-backgrounds/background-generator
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

using System;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.Models;

namespace GoDungeon.Monsters.Tables
{
    /// <summary>
    /// The table of humanoid races
    /// </summary>
    public class HumanoidRaceTable : RandomTable, IHumanoidRaceTable
    {
        /// <summary>
        /// Allowed character races
        /// </summary>
        public HumanoidRaceTable()
        {
            Name = nameof(HumanoidRaceTable);
            ProperName = "Humanoid Race Table";
            TableType = TableTypeEnum.MonsterTable;
            DiceSides = 100;
        }

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
        /// Initialize the game table.  This is a separate method so we 
        /// can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region "Aasimar"
                    //01	Aasimar
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(01, 01),
                        Name = nameof(RaceEnum.Aasimar),
                        Race = RaceEnum.Aasimar,
                    },
                    #endregion

                    #region "Catfolk"
                    //02	Catfolk
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(02, 02),
                        Name = nameof(RaceEnum.Catfolk),
                        Race= RaceEnum.Catfolk,
                    },
                    #endregion

                    #region "Changeling"
                    //03–04	Changeling
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(03, 04),
                        Name = nameof(RaceEnum.Changeling),
                        Race = RaceEnum.Changeling
                    },
                    #endregion

                    #region "Dhampir"
                    //05	Dhampir
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(05, 05),
                        Name = nameof(RaceEnum.Dhampir),
                        Race = RaceEnum.Dhampir
                    },
                    #endregion

                    #region "Duergar"
                    //06	Duergar
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(06, 06),
                        Name = nameof(RaceEnum.Duergar),
                        Race= RaceEnum.Duergar,
                    },
                    #endregion

                    #region "Dwarf"
                    //07–16	Dwarf
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(07, 16),
                        Name = nameof(RaceEnum.Dwarf),
                        Race= RaceEnum.Dwarf,
                    },
                    #endregion

                    #region "Elf"
                    //17–26	Elf
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(17, 26),
                        Name = nameof(RaceEnum.Elf),
                        Race= RaceEnum.Elf,
                    },
                    #endregion

                    #region "Fetchling"
                    //27	Fetchling
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(27, 27),
                        Name = nameof(RaceEnum.Fetchling),
                        Race= RaceEnum.Fetchling,
                    },
                    #endregion

                    #region "Gillman"
                    //28	Gillman
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(28, 28),
                        Name = nameof(RaceEnum.Gillman),
                        Race = RaceEnum.Gillman,
                    },
                    #endregion

                    #region "Gnome"
                    //29–38	Gnome
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(29, 38),
                        Name = nameof(RaceEnum.Gnome),
                        Race = RaceEnum.Gnome
                    },
                    #endregion

                    #region "Goblin"
                    //39	Goblin
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(39, 39),
                        Name = nameof(RaceEnum.Goblin),
                        Race = RaceEnum.Goblin,
                    },
                    #endregion

                    #region "Grippli"
                    //40	Grippli
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(40, 40),
                        Name = nameof(RaceEnum.Grippli),
                        Race = RaceEnum.Grippli
                    },
                    #endregion

                    #region "Half-Elf"
                    //41–50	Half-Elf
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(41, 50),
                        Name = nameof(RaceEnum.HalfElf),
                        ProperName = "Half-Elf",
                        Race = RaceEnum.HalfElf,
                    },
                    #endregion

                    #region "Half-orc"
                    //51–60	Half-orc
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(51, 60),
                        Name = nameof(RaceEnum.HalfOrc),
                        ProperName = "Half-orc",
                        Race= RaceEnum.HalfOrc,
                    },
                    #endregion

                    #region "Halfling"
                    //61–70	Halfling
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(61, 70),
                        Name = nameof(RaceEnum.Halfling),
                        Race= RaceEnum.Halfling,
                    },
                    #endregion

                    #region "Hobgoblin"
                    //71	Hobgoblin
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(71, 71),
                        Name = nameof(RaceEnum.Hobgoblin),
                        Race = RaceEnum.Hobgoblin,
                    },
                    #endregion

                    #region "Human"
                    //72–81	Human
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(72, 81),
                        Name = nameof(RaceEnum.Human),
                        Race = RaceEnum.Human
                    },
                    #endregion

                    #region "Ifrit"
                    //82	Ifrit
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(82, 82),
                        Name = nameof(RaceEnum.Ifrit),
                        Race = RaceEnum.Ifrit
                    },
                    #endregion

                    #region "Kitsune"
                    //83	Kitsune
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(83, 83),
                        Name = nameof(RaceEnum.Kitsune),
                        Race = RaceEnum.Kitsune
                    },
                    #endregion

                    #region "Kobold"
                    //84	Kobold
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(84, 84),
                        Name = nameof(RaceEnum.Kobold),
                        Race = RaceEnum.Kobold,
                    },
                    #endregion

                    #region "Merfolk"
                    //85	Merfolk
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(85, 85),
                        Name = nameof(RaceEnum.Merfolk),
                        Race = RaceEnum.Merfolk
                    },
                    #endregion

                    #region "Nagaji"
                    //86	Nagaji
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(86, 86),
                        Name = nameof(RaceEnum.Nagaji),
                        Race = RaceEnum.Nagaji
                    },
                    #endregion

                    #region "Orc"
                    //87	Orc
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(87, 87),
                        Name = nameof(RaceEnum.Orc),
                        Race = RaceEnum.Orc,
                    },
                    #endregion

                    #region "Oread"
                    //88	Oread
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(88, 88),
                        Name = nameof(RaceEnum.Oread),
                        Race = RaceEnum.Oread,
                    },
                    #endregion

                    #region "Ratfolk"
                    //89	Ratfolk
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(89, 89),
                        Name = nameof(RaceEnum.Ratfolk),
                        Race = RaceEnum.Ratfolk
                    },
                    #endregion

                    #region "Samsaran"
                    //90	Samsaran
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(90, 90),
                        Name = nameof(RaceEnum.Samsaran),
                        Race = RaceEnum.Samsaran
                    },
                    #endregion

                    #region "Strix"
                    //91	Strix
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(91, 91),
                        Name = nameof(RaceEnum.Strix),
                        Race = RaceEnum.Strix,
                    },
                    #endregion

                    #region "Suli"
                    //92	Suli
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(92, 92),
                        Name = nameof(RaceEnum.Suli),
                        Race = RaceEnum.Suli,
                    },
                    #endregion

                    #region "Svirfneblin"
                    //93	Svirfneblin
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(93, 93),
                        Name = nameof(RaceEnum.Svirfneblin),
                        Race = RaceEnum.Svirfneblin
                    },
                    #endregion

                    #region "Sylph"
                    //94	Sylph
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(94, 94),
                        Name = nameof(RaceEnum.Sylph),
                        Race = RaceEnum.Sylph
                    },
                    #endregion

                    #region "Tengu"
                    //95	Tengu
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(95, 95),
                        Name = nameof(RaceEnum.Tengu),
                        Race = RaceEnum.Tengu,
                    },
                    #endregion

                    #region "Tiefling"
                    //96	Tiefling
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(96, 96),
                        Name = nameof(RaceEnum.Tiefling),
                        Race = RaceEnum.Tiefling
                    },
                    #endregion

                    #region "Undine"
                    //97	Undine
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(97, 97),
                        Name = nameof(RaceEnum.Undine),
                        Race = RaceEnum.Undine,
                    },
                    #endregion

                    #region "Vanara"
                    //98	Vanara
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(98, 98),
                        Name = nameof(RaceEnum.Vanara),
                        Race = RaceEnum.Vanara
                    },
                    #endregion

                    #region "Vishkanya"
                    //99	Vishkanya
                    new RaceTableEntryViewModel
                    {
                        Range = new Range(99, 99),
                        Name = nameof(RaceEnum.Vishkanya),
                        Race = RaceEnum.Vishkanya
                    },
                    #endregion

                    #region "Wayang"
                    //100	Wayang
                    new RaceTableEntryViewModel
                    {
                        Range = new Range( 100,100),
                        Name = nameof(RaceEnum.Wayang),
                        Race = RaceEnum.Wayang,
                    },
                    #endregion
                };
            }
        }
    }
}
