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
using NetGore.Core.Models;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

namespace NetGore.Data.Background;

/// <summary>
/// To determine the key person (or people) involved 
/// in the conflict, roll on Table: Conflict Subject. 
/// Only on the rare occasion that the subject was a 
/// child or a young person does the subject affect 
/// the accumulation of CP.
/// </summary>
public class ConflictSubjectTable : RandomRangeTable, IConflictSubjectTable
{
    //Table: Conflict Subject
    //d20 Result
    //1	Commoner
    //2	Merchant
    //3	Tradesperson
    //4	Artisan
    //5	Civic or military official
    //6	Noble
    //7	Leader
    //8	Clergy
    //9	Soldier or warrior
    //10	Spellcaster
    //11	Scoundrel
    //12	Child or young person(increase your CP by 1)
    //13	Family member
    //14	Close friend
    //15	Lover or former lover(roll a d12 instead of a d20 on Table: Romantic Relationships)
    //16	Enemy or rival
    //17	Gangster or underworld figure
    //18	Adventurer
    //19	Humanoid monster
    //20	Non-humanoid monster    
    /// <summary>
    /// Conflict Subject Table
    /// </summary>
    [SetsRequiredMembers]
    public ConflictSubjectTable()
    {
        Name = nameof(ConflictSubjectTable);
        Description = "The Conflicts Subject Table";
        DiceSides = 20;
        Table =
        [
            #region Commoner
            //1	Commoner
            new RandomTableRangeEntry
            {
                Range = new Range(01, 01),
                Name = nameof(ConflictSubjectEnum.Commoner),
                ConflictPoints = 0
            },
            #endregion

            #region Merchant
            //2	Merchant
            new RandomTableRangeEntry
            {
                Range = new Range(02, 02),
                Name = nameof(ConflictSubjectEnum.Merchant),
                ConflictPoints = 0
            },
            #endregion

            #region Tradesperson
            //3	Tradesperson
            new RandomTableRangeEntry
            {
                Range = new Range(03, 03),
                Name = nameof(ConflictSubjectEnum.Tradesperson),
                ConflictPoints = 0
            },
            #endregion

            #region Artisan
            //4	Artisan
            new RandomTableRangeEntry
            {
                Range = new Range(04, 04),
                Name = nameof(ConflictSubjectEnum.Artisan),
                ConflictPoints = 0
            },
            #endregion

            #region Civic or military official
            //5	Civic or military official
            new RandomTableRangeEntry
            {
                Range = new Range(05, 05),
                Name = nameof(ConflictSubjectEnum.Civicormilitaryofficial),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Noble
            //6	Noble
            new RandomTableRangeEntry
            {
                Range = new Range(06, 06),
                Name = nameof(ConflictSubjectEnum.Noble),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Leader
            //7	Leader
            new RandomTableRangeEntry
            {
                Range = new Range(07, 07),
                Name = nameof(ConflictSubjectEnum.Leader),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Clergy
            //8	Clergy
            new RandomTableRangeEntry
            {
                Range = new Range(08, 08),
                Name = nameof(ConflictSubjectEnum.Clergy),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Soldier or warrior
            //9	Soldier or warrior
            new RandomTableRangeEntry
            {
                Range = new Range(09, 09),
                Name = nameof(ConflictSubjectEnum.Soldierorwarrior),
                ProperName = "Soldier or warrior",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Spellcaster
            //10	Spellcaster
            new RandomTableRangeEntry
            {
                Range = new Range(10, 10),
                Name = nameof(ConflictSubjectEnum.Spellcaster),
                ProperName = "Spellcaster",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Scoundrel
            //11	Scoundrel
            new RandomTableRangeEntry
            {
                Range = new Range(11, 11),
                Name = nameof(ConflictSubjectEnum.Scoundrel),
                ProperName = "Scoundrel",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Child or young person
            //12	Child or young person
            new RandomTableRangeEntry
            {
                Range = new Range(12, 12),
                Name = nameof(ConflictSubjectEnum.Child),
                ProperName = "Child or young person",
                ConflictPoints = 1
            },
            #endregion
                    
            #region Family member
            //13	Family member
            new RandomTableRangeEntry
            {
                Range = new Range(13, 13),
                Name = nameof(ConflictSubjectEnum.Familymember),
                ProperName = "Family member",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Close friend
            //14	Close friend
            new RandomTableRangeEntry
            {
                Range = new Range(14, 14),
                Name = nameof(ConflictSubjectEnum.Closefriend),
                ProperName = "Close friend",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Lover or former lover
            //15	Lover or former lover
            new RandomTableRangeEntry
            {
                Range = new Range(15, 15),
                Name = nameof(ConflictSubjectEnum.Loverorformerlover),
                ProperName = "Lover or former lover",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Enemy or rival
            //16	Enemy or rival
            new RandomTableRangeEntry
            {
                Range = new Range(16, 16),
                Name = nameof(ConflictSubjectEnum.Enemyorrival),
                ProperName = "Enemy or rival",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Gangster or underworld figure
            //17	Gangster or underworld figure
            new RandomTableRangeEntry
            {
                Range = new Range(17, 17),
                Name = nameof(ConflictSubjectEnum.Gangsterorunderworldfigure),
                ProperName = "Gangster or underworld figure",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Adventurer
            //18	Adventurer
            new RandomTableRangeEntry
            {
                Range = new Range(18, 18),
                Name = nameof(ConflictSubjectEnum.Adventurer),
                ProperName = "Adventurer",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Humanoid monster
            //19	Humanoid monster
            new RandomTableRangeEntry
            {
                Range = new Range(19, 19),
                Name = nameof(ConflictSubjectEnum.Humanoidmonster),
                ProperName = "Humanoid monster",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Non-humanoid monster
            //20	Non-humanoid monster    
            new RandomTableRangeEntry
            {
                Range = new Range(20, 20),
                Name = nameof(ConflictSubjectEnum.Nonhumanoidmonster),
                ProperName = "Non-humanoid monster",
                ConflictPoints = 0
            },
            #endregion
        ];
    }
}
