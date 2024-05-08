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

namespace GoDungeon.Background.Tables.Dragonborn
{
    /// <summary>
    /// The homeland table
    /// </summary>
    public class DragonbornHomelandTable : RandomTable, IDragonbornHomelandTable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DragonbornHomelandTable()
        {
            DiceSides = 100;
            Name = nameof(DragonbornHomelandTable);
            ProperName = "Dragonborn Homeland Table";
            TableType = TableTypeEnum.RaceTable;
        }

        //Table: Dragonborn Homeland
        //d%	Result
        //01–50	Town or Village You gain access to the Militia Veteran regional trait.
        //51–85	City or Metropolis If you’re a human, you gain access to the Civilized social trait and the Vagabond Child regional trait. If you’re a half-elf, you gain access to the Civilized social trait and the Failed Apprentice race trait. If you’re a half-orc, you gain access to the Brute race trait and the Vagabond Child regional trait.
        //86–95	Frontier You gain access to the Frontier-Forged regional trait.
        //96–100 Unusual Homeland.	Roll on Table: Unusual Homeland.
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
                    #region "Town or Village"
                    //01–50	Town or Village You gain access
                    //to the Militia Veteran regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(01,50),
                        Name = "Town or Village",
                        Description =
                        "You gain access to the Militia Veteran regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
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
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(51,85),
                        Name = "City or Metropolis",
                        Description = "If you’re a human, you gain access to the Civilized social trait and the Vagabond Child regional trait",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.Civilized,
                            TraitEnum.VagabondChild,
                        },
                    },
                    #endregion

                    #region "Frontier"
                    //86–95	Frontier You gain access to the Frontier-Forged regional trait.
                    new BackgroundTableEntryViewModel
                    {
                        Range = new Range(86,95),
                        Name = "Frontier",
                        Description = "You gain access to the Frontier-Forged regional trait.",
                        Traits = new ObservableCollection<TraitEnum>
                        {
                            TraitEnum.FrontierForged,
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
                    },
                    #endregion
                };
            }
        }
    }
}
