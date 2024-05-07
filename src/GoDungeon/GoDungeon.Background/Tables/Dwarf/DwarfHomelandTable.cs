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

using GoDungeon.Background.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Background.Tables.Dwarf
{
    /// <summary>
    /// The homeland table
    /// </summary>
    public class DwarfHomelandTable : RandomTable, IDwarfHomelandTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DwarfHomelandTable()
        {
            DiceSides = 100;
            Name = nameof(DwarfHomelandTable);
            ProperName = "Dwarf Homeland Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Dwarf Homeland
        //d%	Result
        //01–40	Hills or Mountains You gain access to the Goldsniffer race trait and the Highlander regional trait.
        //41–80	Underground You gain access to the Surface Stranger regional trait and the Tunnel Fighter race trait.
        //81–87	Non-Dwarven Town or Village You gain access to the Brewmaster race trait and the Militia Veteran regional trait.
        //88–95	Non-Dwarven City or Metropolis  You gain access to the Brewmaster race trait and the Vagabond Child regional trait.
        //96–100	Unusual Homeland.	Roll on Table: Unusual Homeland.
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
                    #region "Hills or Mountains"
                    //01–40	Hills or Mountains You gain
                    //access to the Goldsniffer race trait
                    //and the Highlander regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,40),
                        Name = "Hills or Mountains",
                        ProperName = "Hills or Mountains",
                        Description =
                            "You gain access to the " +
                            "Goldsniffer race trait and " +
                            "the Highlander regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Goldsniffer,
                            TraitEnum.Highlander
                        },
                    },
                    #endregion

                    #region Underground
                    //41–80	Underground You gain access to
                    //the Surface Stranger regional trait
                    //and the Tunnel Fighter race trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(41,80),
                        Name = "Underground",
                        ProperName = "Underground",
                        Description =
                            "You gain access to the Surface " +
                            "Stranger regional trait and the " +
                            "Tunnel Fighter race trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.SurfaceStranger,
                            TraitEnum.TunnelFighter,
                        },

                    },
                    #endregion

                    #region "Non-Dwarven Town or Village"
                    //81–87	Non-Dwarven Town or Village You
                    //gain access to the Brewmaster race
                    //trait and the Militia Veteran regional
                    //trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(81,87),
                        Name = "Non-Dwarven Town or Village",
                        ProperName = "Non-Dwarven Town or Village",
                        Description =
                            "You gain access to the Brewmaster " +
                            "race trait and the Militia Veteran " +
                            "regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Brewmaster,
                            TraitEnum.MilitiaVeteran,
                        },
                    },
                    #endregion

                    #region "Non-Dwarven City or Metropolis"
                    // 88–95 Non-Dwarven City or Metropolis
                    // You gain access to the Brewmaster race
                    // trait and the Vagabond Child regional
                    // trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(88,95),
                        Name = "Non-Dwarven City or Metropolis",
                        ProperName = "Non-Dwarven City or Metropolis",
                        Description =
                            "You gain access to the Brewmaster " +
                            "race trait and the Vagabond Child " +
                            "regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Brewmaster,
                            TraitEnum.VagabondChild,
                        },
                    },
                    #endregion
                        
                    #region "Unusual Homeland."
                    //96–100 Unusual Homeland.	Roll on Table:
                    //Unusual Homeland.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(96,100),
                        Name = "Unusual Homeland",
                        ProperName = "Unusual Homeland",
                    },
                    #endregion
                };
            }
        }
    }
}
