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

using System;
using System.Collections.ObjectModel;

using GoDungeon.Background.Enum;
using GoDungeon.Background.Interfaces;
using GoDungeon.Background.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Background.Tables
{
    /// <summary>
    /// You grew up in a region not typically associated 
    /// with the lands that your people call home. Roll 
    /// on Table: Unusual Homeland to determine the 
    /// homeland of your family. If the result is one 
    /// that is typical for your race, this region is 
    /// one where there are few other members of your 
    /// race, outside of your family.
    /// </summary>
    public class UnusualHomelandTable : RandomTable, IUnusualHomelandTable
    {
        /// <summary>
        /// The Unusual Homeland Table
        /// </summary>
        public UnusualHomelandTable()
        {
            Name = nameof(UnusualHomelandTable);
            ProperName = "Unusual Homeland Table";
            TableType = TableTypeEnum.BackgroundTable;
            Description = "You grew up in a region not typically associated with the lands that your people call home. Roll on Table: Unusual Homeland to determine the homeland of your family. If the result is one that is typical for your race, this region is one where there are few other members of your race, outside of your family.";
            DiceSides = 100;
        }

        //Table: Unusual Homeland
        //d%	Result
        //01–10	Subterranean You gain access to the Surface Stranger regional trait.
        //11–25	Mountains You gain access to the Highlander regional trait.
        //26–40	Plains You gain access to the Savanna Child regional trait.
        //41–50	Town or Village You gain access to the Militia Veteran regional trait.
        //51–60	City or Metropolis You gain access to the Civilized social trait and the Vagabond Child regional trait.
        //61–70	Forest You gain access to the Log Roller regional trait.
        //71–80	River, Swamp, or Wetlands   You gain access to the River Rat regional trait.
        //81–85	Desert You gain access to the Desert Child regional trait.
        //86–90	Sea You gain access to the Sea-Souled regional trait.
        //91–95	Tundra You gain access to the Tundra Child regional trait.
        //96–100	Another Plane   Your GM chooses the plane.You gain access to the Scholar of the Great Beyond faith trait    
        /// <summary>
        /// Initialize the game table.  This is a separate method so 
        /// we can create a game table for it's meta properties
        /// with out creating the actual able values.  A bit of 
        /// optimization to conserve memory on big tables
        /// </summary>
        public override void InitializeTable()
        {
            if (Table == null || Table.Count == 0)
            {
                Table = new ObservableCollection<IGameTableEntry>
                {
                    #region Subterranean
                    //01–10	Subterranean You gain access to
                    //the Surface Stranger regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01, 10),
                        Name = nameof(UnusualHomelandEnum.Subterranean),
                        Description =
                            "You gain access to the Surface " +
                            "Stranger regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.SurfaceStranger,
                        },
                    },
                    #endregion

                    #region Mountains
                    //11–25	Mountains You gain access to the
                    //Highlander regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(11, 25),
                        Name = nameof(UnusualHomelandEnum.Mountains),
                        Description =
                            "You gain access to the Highlander " +
                            "regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Highlander,
                        },
                    },
                    #endregion

                    #region Plains
                    //26–40	Plains You gain access to the
                    //Savanna Child regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(26, 40),
                        Name = nameof(UnusualHomelandEnum.Plains),
                        Description =
                            "You gain access to the Savanna " +
                            "Child regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.SavannahChild,
                        },
                    },
                    #endregion

                    #region "Town or Village"
                    //41–50	Town or Village You gain access
                    //to the Militia Veteran regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(41, 50),
                        Name = nameof(UnusualHomelandEnum.TownorVillage),
                        ProperName = "Town or Village",
                        Description =
                            "You gain access to the Militia " +
                            "Veteran regional trait",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.MilitiaVeteran,
                        },
                    },
                    #endregion

                    #region "City or Metropolis"
                    //51–60	City or Metropolis You gain access
                    //to the Civilized social trait and the
                    //Vagabond Child regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(51, 60),
                        Name = nameof(UnusualHomelandEnum.CityorMetropolis),
                        ProperName = "City or Metropolis",
                        Description =
                            "You gain access to the Civilized " +
                            "social trait and the Vagabond " +
                            "Child regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Civilized,
                            TraitEnum.VagabondChild,
                        },
                    },
                    #endregion

                    #region Forest
                    //61–70	Forest You gain access to the
                    //Log Roller regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(61, 70),
                        Name = nameof(UnusualHomelandEnum.Forest),
                        Description =
                            "You gain access to the Log Jumper " +
                            "regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.LongJumper,
                        },
                    },
                    #endregion

                    #region "River, Swamp, or Wetlands"
                    //71–80	River, Swamp, or Wetlands You gain
                    //access to the River Rat regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(71, 80),
                        Name = nameof(UnusualHomelandEnum.RiverSwamporWetlands),
                        ProperName = "River, Swamp, or Wetlands",
                        Description =
                            "You gain access to the River Rat regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.RiverRat,
                        },
                    },
                    #endregion

                    #region Desert
                    //81–85	Desert You gain access to the
                    //Desert Child regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(81, 85),
                        Name = nameof(UnusualHomelandEnum.Desert),
                        Description =
                            "You gain access to the Desert Child regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.DesertChild,
                        },
                    },
                    #endregion

                    #region Sea-Souled
                    //86–90	Sea You gain access to the
                    //Sea-Souled regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(86, 90),
                        Name = nameof(UnusualHomelandEnum.SeaSouled),
                        ProperName = "Sea-Souled",
                        Description =
                            "You gain access to the Sea-Souled regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.SeaSouled,
                        },
                    },
                    #endregion

                    #region Tundra
                    //91–95	Tundra You gain access to the
                    //Tundra Child regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(91, 95),
                        Name = nameof(UnusualHomelandEnum.Tundra),
                        Description =
                            "You gain access to the Tundra Child regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.TundraChild,
                        },
                    },
                    #endregion

                    #region "Another Plane"
                    //96–100 Another Plane You gain access
                    //to the Scholar of the Great Beyond
                    //faith trait    
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(96, 100),
                        Name = nameof(UnusualHomelandEnum.AnotherPlane),
                        ProperName = "Another Plane",
                        Description =
                            "You gain access to the Scholar of the Great Beyond faith trait",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.ScholaroftheGreatBeyond,
                        },
                    },
                    #endregion
                };

            }
        }
    }
}
