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
    /// This table lists 20 conflicts, ranging from minor 
    /// indiscretions to grievous sins. The type of die 
    /// you roll on this table is based on the needs of 
    /// the campaign as well as your character’s 
    /// starting class. First, consult with your GM; 
    /// If you can play any alignment in the campaign, 
    /// roll a d20. If your campaign allows only nonevil 
    /// characters, roll a d12. If you are playing a 
    /// paladin or some other character who must be good, 
    /// roll a d6. Once you are done, proceed to 
    /// Table: Conflict Subject and to the tables and 
    /// sections subsequent to it.
    /// </summary>
    public class ConflictTable : NamedTable, IConflictTable
    {
        /// <summary>
        /// Conflicts Table
        /// </summary>
        public ConflictTable()
        {
            Name = nameof(ConflictTable);
            ProperName = "Conflicts Table";
            TableType = TableTypeEnum.ConflictTable;
            Description = "Begin by rolling on Table: Conflicts. This table lists 20 conflicts, ranging from minor indiscretions to grievous sins. The type of die you roll on this table is based on the needs of the campaign as well as your character’s starting class. First, consult with your GM; If you can play any alignment in the campaign, roll a d20. If your campaign allows only nonevil characters, roll a d12. If you are playing a paladin or some other character who must be good, roll a d6";
        }

        //Table: Conflicts
        //d20 Result CP
        //1	Minor Failure   You failed a friend, family member, or loved one who depended on you to fulfill an important task.  1
        //2	Petty Crime You committed a minor crime, like vandalism, trespassing, or mischief.	1
        //3	Told a Lie You deliberately made someone believe something that was not true to further your own goals.    1
        //4	Broke a Promise You swore an oath or vow that was important to someone else, but you did not keep your promise. 1
        //5	Humiliation You publicly humiliated or scandalized someone with either true or slanderous information.  2
        //6	Negligence You caused someone else to suffer by your own inaction, disregard, or excessive recklessness.   2
        //7	Minor Theft You stole several small or inexpensive items that belonged to someone else.	2
        //8	Seducer You tempted or manipulated someone to act in accordance with your whim, careless of whether it was in their own best interests.	3
        //9	Cheater You broke a rule, law, contract, or agreement for your own gain.    3
        //10	Betrayal You betrayed someone who trusted you.   4
        //11	Malign Associates   You allied with a destructive creature, organization, or individual.	4
        //12	Destroyed a Reputation You deliberately ruined the honor, reputation, or fortunes of another individual or group.  5
        //13	Major Theft You stole expensive items.	5
        //14	Corrupted an Innocent You counseled an otherwise innocent person who trusted you, toward adverse choices. 6
        //15	Blackmailed You used sensitive knowledge or threats to force someone’s cooperation.	6
        //16	Destruction You destroyed someone else’s property.	6
        //17	Armed Robbery   You robbed someone with the threat of violence.	6
        //18	Violent Crime   You beat, assaulted, or mutilated someone.  7
        //19	Murder You killed someone.	8
        //20	Mass Murder You killed several sentient beings. 12
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
                    #region Minor Failure
                    //1	Minor Failure   You failed a friend, family member, or loved one who depended on you to fulfill an important task.
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.MinorFailure),
                        ProperName = "Minor Failure",
                        Description =
                            "You failed a friend, family " +
                            "member, or loved one who depended " +
                            "on you to fulfill an important " +
                            "task.",
                        ConflictPoints = 1
                    },
                    #endregion

                    #region Petty Crime
                    // 2	Petty Crime You committed a minor crime, like vandalism, trespassing, or mischief.	1
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.PettyCrime),
                        ProperName = "Petty Crime",
                        Description =
                            "You committed a minor crime, " +
                            "like vandalism, trespassing, or " +
                            "mischief.",
                        ConflictPoints = 1
                    },
                    #endregion

                    #region Told a Lie
                    // 3	Told a Lie You deliberately made someone believe something that was not true to further your own goals.    1
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.ToldaLie),
                        ProperName = "Told a Lie",
                        Description =
                            "You deliberately made someone " +
                            "believe something that was not " +
                            "true to further your own goals.",
                        ConflictPoints = 1
                    },
                    #endregion

                    #region Broke a Promise
                    // 4	Broke a Promise You swore an oath or vow that was important to someone else, but you did not keep your promise. 1
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.BrokeaPromise),
                        ProperName = "Broke a Promise",
                        Description =
                            "You swore an oath or vow that was " +
                            "important to someone else, but you " +
                            "did not keep your promise.",
                        ConflictPoints = 1
                    },
                    #endregion

                    #region Humiliation
                    // 5	Humiliation You publicly humiliated or scandalized someone with either true or slanderous information.  2
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.Humiliation),
                        Description =
                            "You publicly humiliated or " +
                            "scandalized someone with either " +
                            "true or slanderous information.",
                        ConflictPoints = 2
                    },
                    #endregion

                    #region Negligence
                    // 6	Negligence You caused someone else to suffer by your own inaction, disregard, or excessive recklessness.   2
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.Negligence),
                        Description =
                            "You caused someone else to suffer " +
                            "by your own inaction, disregard, " +
                            "or excessive recklessness.",
                        ConflictPoints = 2
                    },
                    #endregion

                    #region Minor Theft
                    // 7	Minor Theft You stole several small or inexpensive items that belonged to someone else.	2
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.MinorTheft),
                        ProperName = "Minor Theft",
                        Description =
                            "You stole several small or " +
                            "inexpensive items that belonged " +
                            "to someone else.",
                        ConflictPoints = 2
                    },
                    #endregion

                    #region Seducer
                    // 8	Seducer 
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.Seducer),
                        Description =
                            "You tempted or manipulated someone " +
                            "to act in accordance with your whim, " +
                            "careless of whether it was in their " +
                            "own best interests.",
                        ConflictPoints = 3
                    },
                    #endregion

                    #region Cheater
                    // 9	Cheater You broke a rule, law, contract, or agreement for your own gain.    3
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.Cheater),
                        Description =
                            "You broke a rule, law, contract, " +
                            "or agreement for your own gain.",
                        ConflictPoints = 3
                    },
                    #endregion

                    #region Betrayal
                    // 10	Betrayal 
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.Betrayal),
                        Description = "You betrayed someone who trusted you.",
                        ConflictPoints = 4
                    },
                    #endregion

                    #region Malign Associates
                    // 11	Malign Associates   
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.MalignAssociates),
                        ProperName = "Malign Associates",
                        Description =
                            "You allied with a destructive " +
                            "creature, organization, or " +
                            "individual.",
                        ConflictPoints = 4
                    },
                    #endregion

                    #region Destroyed a Reputation
                    //  12	Destroyed a Reputation 
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.DestroyedaReputation),
                        ProperName = "Destroyed a Reputation",
                        Description =
                            "You deliberately ruined the honor, " +
                            "reputation, or fortunes of another " +
                            "individual or group.",
                        ConflictPoints = 5
                    },
                    #endregion

                    #region Major Theft
                    // 13	Major Theft 
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.MajorTheft),
                        ProperName = "Major Theft",
                        Description = "You stole expensive items.",
                        ConflictPoints = 5
                    },
                    #endregion

                    #region Corrupted an Innocent
                    // 14	Corrupted an Innocent 
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.CorruptedanInnocent),
                        ProperName = "Corrupted an Innocent",
                        Description =
                            "You counseled an otherwise " +
                            "innocent person who trusted you, " +
                            "toward adverse choices.",
                        ConflictPoints = 6
                    },
                    #endregion

                    #region Blackmailed
                    // 15	Blackmailed You used sensitive knowledge or threats to force someone’s cooperation.	6
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.Blackmailed),
                        ProperName = "Blackmailed",
                        Description =
                            "You used sensitive knowledge or " +
                            "threats to force someone’s " +
                            "cooperation.",
                        ConflictPoints = 6
                    },
                    #endregion

                    #region Destruction
                    //16	Destruction You destroyed someone else’s property.	6
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.Destruction),
                        ProperName = "Destruction",
                        Description =
                            "You destroyed someone else’s property.",
                        ConflictPoints = 6
                    },
                    #endregion

                    #region Armed Robbery
                    // 17	Armed Robbery
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.ArmedRobbery),
                        ProperName = "Armed Robbery",
                        Description =
                            "You robbed someone with the threat " +
                            "of violence.",
                        ConflictPoints = 6
                    },
                    #endregion

                    #region Violent Crime
                    //18	Violent Crime   
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.ViolentCrime),
                        ProperName = "Violent Crime",
                        Description =
                            "You beat, assaulted, or mutilated someone.",
                        ConflictPoints = 7
                    },
                    #endregion

                    #region Murder
                    // 19	Murder
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.Murder),
                        ProperName = "Murder",
                        Description = "Murder You killed someone.",
                        ConflictPoints = 8
                    },
                    #endregion

                    #region Mass Murder
                    //20	Mass Murder
                    new ConflictTableEntryViewModel
                    {
                        Name = nameof(ConflictEnum.MassMurder),
                        ProperName = "Mass Murder",
                        Description = "You killed several sentient beings.",
                        ConflictPoints = 12
                    },
                    #endregion
                };
            }
        }
    }
}
