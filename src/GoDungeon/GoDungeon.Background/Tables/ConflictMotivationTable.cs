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
    /// To determine the source of your motivation for 
    /// the conflict, roll on Table: Motivation. If 
    /// the campaign allows the full spectrum of 
    /// alignments, roll a d10 on this table. If 
    /// the campaign allows only nonevil alignments, 
    /// roll a d8. If you’re a paladin, roll a d4. 
    /// The motivation affects the CP gained from 
    /// the conflict.
    /// </summary>
    public class ConflictMotivationTable : RandomTable, IConflictMotivationTable
    {
        /// <summary>
        /// Conflict Motivation Table
        /// </summary>
        public ConflictMotivationTable()
        {
            Name = nameof(ConflictMotivationTable);
            ProperName = "Conflict Motivation Table";
            DiceSides = 10;
            TableType = TableTypeEnum.ConflictTable;
            Description = "To determine the source of your motivation for the conflict, roll on Table: Motivation. If the campaign allows the full spectrum of alignments, roll a d10 on this table. If the campaign allows only nonevil alignments, roll a d8. If you’re a paladin, roll a d4. The motivation affects the CP gained from the conflict.";
        }

        //Table: Motivation
        //d10 Result CP
        //1	Justice	1
        //2	Love	1
        //3	Pressured or Manipulated	2
        //4	Religion	2
        //5	Family	3
        //6	Money	3
        //7	Jealousy	4
        //8	Hatred or Malice	4
        //9	Pleasure	5
        //10	Amusement or Entertainment	5    
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
                    #region Justice
                    //1	Justice	1
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(1,1),
                        Name = nameof(ConflictMotivationEnum.Justice),
                        ProperName = nameof(ConflictMotivationEnum.Justice),
                        ConflictPoints = 1
                    },
                    #endregion

                    #region Love
                    //2	Love	1
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(2,2),
                        Name = nameof(ConflictMotivationEnum.Love),
                        ProperName = nameof(ConflictMotivationEnum.Love),
                        ConflictPoints = 1
                    },
                    #endregion

                    #region Pressured or Manipulated
                    //3	Pressured or Manipulated	2
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(3,3),
                        Name = nameof(ConflictMotivationEnum.PressuredorManipulated),
                        ProperName = "Pressured or Manipulated",
                        ConflictPoints = 2
                    },
                    #endregion

                    #region Religion
                    //4	Religion	2
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(4,4),
                        Name = nameof(ConflictMotivationEnum.Religion),
                        ProperName = nameof(ConflictMotivationEnum.Religion),
                        ConflictPoints = 2
                    },
                    #endregion

                    #region Family
                    //5	Family	3
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(5,5),
                        Name = nameof(ConflictMotivationEnum.Family),
                        ProperName = nameof(ConflictMotivationEnum.Family),
                        ConflictPoints = 3
                    },
                    #endregion

                    #region Money
                    //6	Money	3
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(6,6),
                        Name = nameof(ConflictMotivationEnum.Money),
                        ProperName = nameof(ConflictMotivationEnum.Money),
                        ConflictPoints = 3
                    },
                    #endregion

                    #region Jealousy
                    //7	Jealousy	4
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(7,7),
                        Name = nameof(ConflictMotivationEnum.Jealousy),
                        ProperName = nameof(ConflictMotivationEnum.Jealousy),
                        ConflictPoints = 4
                    },
                    #endregion

                    #region Hatred or Malice
                    //8	Hatred or Malice	4
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(8,8),
                        Name = nameof(ConflictMotivationEnum.HatredorMalice),
                        ProperName = "Hatred or Malice",
                        ConflictPoints = 4
                    },
                    #endregion

                    #region Pleasure
                    //9	Pleasure	5
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(9,9),
                        Name = nameof(ConflictMotivationEnum.Pleasure),
                        ProperName = nameof(ConflictMotivationEnum.Pleasure),
                        ConflictPoints = 5
                    },
                    #endregion

                    #region Amusement or Entertainment
                    //10	Amusement or Entertainment	5    
                    new ConflictTableEntryViewModel
                    {
                        Range = new System.Range(10,10),
                        Name = nameof(ConflictMotivationEnum.AmusementorEntertainment),
                        ProperName = "Amusement or Entertainment",
                        ConflictPoints = 5
                    },
                    #endregion
                };
            }
        }
    }
}
