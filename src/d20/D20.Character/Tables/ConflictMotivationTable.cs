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

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Character.Tables;

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
    /// Conflict Motivation Table
    /// </summary>
    [SetsRequiredMembers]
    public ConflictMotivationTable()
    {
        Name = nameof(ConflictMotivationTable);
        ProperName = "Conflict Motivation Table";
        TableType = TableTypeEnum.ConflictTable;
        Description = "To determine the source of your motivation for the conflict, roll on Table: Motivation. If the campaign allows the full spectrum of alignments, roll a d10 on this table. If the campaign allows only nonevil alignments, roll a d8. If you’re a paladin, roll a d4. The motivation affects the CP gained from the conflict.";
        Table =
        [
            #region Justice
            //1	Justice	1
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.Justice),
                ConflictPoints = 1
            },
            #endregion

            #region Love
            //2	Love	1
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.Love),
                ConflictPoints = 1
            },
            #endregion

            #region Pressured or Manipulated
            //3	Pressured or Manipulated	2
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.PressuredorManipulated),
                ProperName = "Pressured or Manipulated",
                ConflictPoints = 2
            },
            #endregion

            #region Religion
            //4	Religion	2
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.Religion),
                ProperName = "Religion",
                ConflictPoints = 2
            },
            #endregion

            #region Family
            //5	Family	3
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.Family),
                ProperName = "Family",
                ConflictPoints = 3
            },
            #endregion

            #region Money
            //6	Money	3
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.Money),
                ProperName = "Money",
                ConflictPoints = 3
            },
            #endregion

            #region Jealousy
            //7	Jealousy	4
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.Jealousy),
                ProperName = "Jealousy",
                ConflictPoints = 4
            },
            #endregion

            #region Hatred or Malice
            //8	Hatred or Malice	4
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.HatredorMalice),
                ProperName = "Hatred or Malice",
                ConflictPoints = 4
            },
            #endregion

            #region Pleasure
            //9	Pleasure	5
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.Pleasure),
                ProperName = "Pleasure",
                ConflictPoints = 5
            },
            #endregion

            #region Amusement or Entertainment
            //10	Amusement or Entertainment	5    
            new ConflictTableEntry
            {
                Name = nameof(ConflictMotivationEnum.AmusementorEntertainment),
                ProperName = "Pleasure",
                ConflictPoints = 5
            },
            #endregion
        ];
    }
}
