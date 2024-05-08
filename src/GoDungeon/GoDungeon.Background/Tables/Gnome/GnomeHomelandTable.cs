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

namespace GoDungeon.Background.Tables.Gnome
{
    /// <summary>
    /// The homeland table
    /// </summary>
    public class GnomeHomelandTable : RandomTable, IGnomeHomelandTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GnomeHomelandTable()
        {
            DiceSides = 100;
            Name = nameof(GnomeHomelandTable);
            ProperName = "Gnome Homeland Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Gnome Homeland
        //d%	Result
        //01–30	Forest You gain access to the Log Roller regional trait and the Animal Friend race trait.
        //31–65	Non-Gnome Town or Village   You gain access to the Animal Friend race trait.
        //66–95	Non-Gnome City or Metropolis    You gain access to the Rapscallion race trait.
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
                    #region "Forest"
                    //01–30	Forest You gain access to the
                    //Log Roller regional trait and the
                    //Animal Friend race trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01, 30),
                        Name = "Forest",
                        Description =
                            "You gain access to the " +
                            "Log Roller regional trait and " +
                            "the Animal Friend race trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.AnimalFriend
                        },
                    },
                    #endregion

                    #region "Non-Gnome Town or Village"
                    //31–65	Non-Gnome Town or Village   You gain access to the Animal Friend race trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(31, 65),
                        Name = "Non-Gnome Town or Village",
                        Description =
                            "You gain access to the Animal Friend race trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.AnimalFriend,
                        },
                    },
                    #endregion

                    #region "Non-Gnome City or Metropolis"
                    //66–95	Non-Gnome City or Metropolis You gain access to the Rapscallion race trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(66, 95),
                        Name = "Non-Gnome City or Metropolis",
                        Description =
                            "You gain access to the Rapscallion race trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Rapscallion,
                        },
                    },
                    #endregion

                    #region "Unusual Homeland."
                    //96–100 Unusual Homeland.	Roll on Table:
                    //Unusual Homeland.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(96, 100),
                        Name = "Unusual Homeland",
                    },
                    #endregion
                };
            }
        }
    }
}
