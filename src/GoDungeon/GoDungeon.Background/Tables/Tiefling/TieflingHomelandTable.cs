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

using GoDungeon.Background.ViewModels;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.Background.Tables.Tiefling
{
    /// <summary>
    /// The homeland table
    /// </summary>
    public class TieflingHomelandTable : RandomTable, ITieflingHomelandTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TieflingHomelandTable()
        {
            DiceSides = 100;
            Name = nameof(TieflingHomelandTable);
            ProperName = "Tiefling Homeland Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Half-Orc Homeland
        //d%	Result
        //01–25	Subterranean You gain access to either the Scrapper race trait or the Surface Stranger regional trait.
        //26–60	Orc Settlement  You gain access to the Scrapper race trait.
        //61–75	Raised in a Human Homeland.Roll on Table: Human Homeland.
        //76–90	No True Homeland You have lived a life on the run and gain access to the Outcast race trait.
        //91–100	Unusual Homeland.	Roll on Table: Unusual Homeland.
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
                    #region "Subterranean"
                    //01–25	Subterranean You gain access to
                    //either the Scrapper race trait or the
                    //Surface Stranger regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,25),
                        Name = "Subterranean",
                        Description =
                            "You gain access to either the " +
                            "Scrapper race trait or the " +
                            "Surface Stranger regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Scrapper,
                            TraitEnum.SurfaceStranger,
                        },
                    },
                    #endregion

                    #region Raised in a Human Homeland
                    // 61–75	Raised in a Human Homeland.	Roll on Table: Human Homeland.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(61,75),
                        Name = "Raised in a Human Homeland",
                        Description = "Roll on Table: Human Homeland",
                        //AlternateTable = Human.HomelandTable
                    },
                    #endregion

                    #region "Orc Settlement"
                    //26–60	Orc Settlement  You gain access to the Scrapper race trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(26,60),
                        Name = "Orc Settlement",
                        Description =
                            "You gain access to the Scrapper race trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Scrapper,
                        },
                    },
                    #endregion

                    #region "No True Homeland"
                    //76–90	No True Homeland You have lived a life on the run and gain access to the Outcast race trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(76,90),
                        Name = "No True Homeland",
                        Description =
                            "You have lived a life on the run " +
                            "and gain access to the Outcast " +
                            "race trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Outcast,
                        },
                    },
                    #endregion
                        
                    #region "Unusual Homeland."
                    //91–100 Unusual Homeland.	Roll on Table:
                    //Unusual Homeland.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(91,100),
                        Name = "Unusual Homeland",
                    },
                    #endregion
                };
            }
        }
    }
}
