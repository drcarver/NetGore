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
/// To determine the key person (or people) involved 
/// in the conflict, roll on Table: Conflict Subject. 
/// Only on the rare occasion that the subject was a 
/// child or a young person does the subject affect 
/// the accumulation of CP.
/// </summary>
public class ConflictSubjectTable : NamedTable, IConflictSubjectTable
{
    /// <summary>
    /// Conflict Subject Table
    /// </summary>
    [SetsRequiredMembers]
    public ConflictSubjectTable()
    {
        Name = nameof(ConflictSubjectTable);
        ProperName = "Conflicts Subject Table";
        TableType = TableTypeEnum.ConflictTable;
        Description = "To determine the key person (or people) involved in the conflict, roll on Table: Conflict Subject. Only on the rare occasion that the subject was a child or a young person does the subject affect the accumulation of CP.";
    }

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
    /// Initialize the game table.  This is a seperate method so we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of optimiation to conserve memeory on big tables
    /// </summary>
    public override void InitializeTable()
    {
        Table =
        [
            #region Commoner
            //1	Commoner
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Commoner),
                ConflictPoints = 0
            },
            #endregion

            #region Merchant
            //2	Merchant
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Merchant),
                ConflictPoints = 0
            },
            #endregion

            #region Tradesperson
            //3	Tradesperson
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Tradesperson),
                ConflictPoints = 0
            },
            #endregion

            #region Artisan
            //4	Artisan
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Artisan),
                ConflictPoints = 0
            },
            #endregion

            #region Civic or military official
            //5	Civic or military official
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Civicormilitaryofficial),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Noble
            //6	Noble
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Noble),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Leader
            //7	Leader
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Leader),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Clergy
            //8	Clergy
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Clergy),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Soldier or warrior
            //9	Soldier or warrior
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Soldierorwarrior),
                ProperName = "Soldier or warrior",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Spellcaster
            //10	Spellcaster
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Spellcaster),
                ProperName = "Spellcaster",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Scoundrel
            //11	Scoundrel
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Scoundrel),
                ProperName = "Scoundrel",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Child or young person
            //12	Child or young person
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Child),
                ProperName = "Child or young person",
                ConflictPoints = 1
            },
            #endregion
                    
            #region Family member
            //13	Family member
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Familymember),
                ProperName = "Family member",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Close friend
            //14	Close friend
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Closefriend),
                ProperName = "Close friend",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Lover or former lover
            //15	Lover or former lover
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Loverorformerlover),
                ProperName = "Lover or former lover",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Enemy or rival
            //16	Enemy or rival
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Enemyorrival),
                ProperName = "Enemy or rival",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Gangster or underworld figure
            //17	Gangster or underworld figure
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Gangsterorunderworldfigure),
                ProperName = "Gangster or underworld figure",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Adventurer
            //18	Adventurer
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Adventurer),
                ProperName = "Adventurer",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Humanoid monster
            //19	Humanoid monster
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Humanoidmonster),
                ProperName = "Humanoid monster",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Non-humanoid monster
            //20	Non-humanoid monster    
            new ConflictTableEntry
            {
                Name = nameof(ConflictSubjectEnum.Nonhumanoidmonster),
                ProperName = "Non-humanoid monster",
                ConflictPoints = 0
            },
            #endregion
        ];
    }
}
