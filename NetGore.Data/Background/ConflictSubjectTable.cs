using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;
using System;

using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

/// <summary>
/// To determine the key person (or people) involved 
/// in the conflict, roll on Table: Conflict Subject. 
/// Only on the rare occasion that the subject was a 
/// child or a young person does the subject affect 
/// the accumulation of CP.
/// </summary>
public partial class BackgroundTables
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
    public static RandomTable ConflictSubjectTable { get; } = new()
    {
        Name = "The Conflicts Subject Table",
        DiceSides = 20,
        Table =
        [
            #region Commoner
            //1	Commoner
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 01,
                Name = nameof(ConflictSubjectEnum.Commoner),
                ConflictPoints = 0
            },
            #endregion

            #region Merchant
            //2	Merchant
            new RandomTableEntry
            {
                LowerRange = 02,
                UpperRange = 02,
                Name = nameof(ConflictSubjectEnum.Merchant),
                ConflictPoints = 0
            },
            #endregion

            #region Tradesperson
            //3	Tradesperson
            new RandomTableEntry
            {
                LowerRange = 03,
                UpperRange = 03,
                Name = nameof(ConflictSubjectEnum.Tradesperson),
                ConflictPoints = 0
            },
            #endregion

            #region Artisan
            //4	Artisan
            new RandomTableEntry
            {
                LowerRange = 04,
                UpperRange = 04,
                Name = nameof(ConflictSubjectEnum.Artisan),
                ConflictPoints = 0
            },
            #endregion

            #region Civic or military official
            //5	Civic or military official
            new RandomTableEntry
            {
                LowerRange = 05,
                UpperRange = 05,
                Name = nameof(ConflictSubjectEnum.Civicormilitaryofficial),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Noble
            //6	Noble
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 06,
                Name = nameof(ConflictSubjectEnum.Noble),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Leader
            //7	Leader
            new RandomTableEntry
            {
                LowerRange = 07,
                UpperRange = 07,
                Name = nameof(ConflictSubjectEnum.Leader),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Clergy
            //8	Clergy
            new RandomTableEntry
            {
                LowerRange = 08,
                UpperRange = 08,
                Name = nameof(ConflictSubjectEnum.Clergy),
                ConflictPoints = 0
            },
            #endregion
                    
            #region Soldier or warrior
            //9	Soldier or warrior
            new RandomTableEntry
            {
                LowerRange = 09,
                UpperRange = 09,
                Name = nameof(ConflictSubjectEnum.Soldierorwarrior),
                ProperName = "Soldier or warrior",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Spellcaster
            //10	Spellcaster
            new RandomTableEntry
            {
                LowerRange = 10,
                UpperRange = 10,
                Name = nameof(ConflictSubjectEnum.Spellcaster),
                ProperName = "Spellcaster",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Scoundrel
            //11	Scoundrel
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 11,
                Name = nameof(ConflictSubjectEnum.Scoundrel),
                ProperName = "Scoundrel",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Child or young person
            //12	Child or young person
            new RandomTableEntry
            {
                LowerRange = 12,
                UpperRange = 12,
                Name = nameof(ConflictSubjectEnum.Child),
                ProperName = "Child or young person",
                ConflictPoints = 1
            },
            #endregion
                    
            #region Family member
            //13	Family member
            new RandomTableEntry
            {
                LowerRange = 13,
                UpperRange = 13,
                Name = nameof(ConflictSubjectEnum.Familymember),
                ProperName = "Family member",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Close friend
            //14	Close friend
            new RandomTableEntry
            {
                LowerRange = 14,
                UpperRange = 14,
                Name = nameof(ConflictSubjectEnum.Closefriend),
                ProperName = "Close friend",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Lover or former lover
            //15	Lover or former lover
            new RandomTableEntry
            {
                LowerRange = 15,
                UpperRange = 15,
                Name = nameof(ConflictSubjectEnum.Loverorformerlover),
                ProperName = "Lover or former lover",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Enemy or rival
            //16	Enemy or rival
            new RandomTableEntry
            {
                LowerRange = 16,
                UpperRange = 16,
                Name = nameof(ConflictSubjectEnum.Enemyorrival),
                ProperName = "Enemy or rival",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Gangster or underworld figure
            //17	Gangster or underworld figure
            new RandomTableEntry
            {
                LowerRange = 17,
                UpperRange = 17,
                Name = nameof(ConflictSubjectEnum.Gangsterorunderworldfigure),
                ProperName = "Gangster or underworld figure",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Adventurer
            //18	Adventurer
            new RandomTableEntry
            {
                LowerRange = 18,
                UpperRange = 18,
                Name = nameof(ConflictSubjectEnum.Adventurer),
                ProperName = "Adventurer",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Humanoid monster
            //19	Humanoid monster
            new RandomTableEntry
            {
                LowerRange = 19,
                UpperRange = 19,
                Name = nameof(ConflictSubjectEnum.Humanoidmonster),
                ProperName = "Humanoid monster",
                ConflictPoints = 0
            },
            #endregion
                    
            #region Non-humanoid monster
            //20	Non-humanoid monster    
            new RandomTableEntry
            {
                LowerRange = 20,
                UpperRange = 20,
                Name = nameof(ConflictSubjectEnum.Nonhumanoidmonster),
                ProperName = "Non-humanoid monster",
                ConflictPoints = 0
            },
            #endregion
        ],
    };
}
