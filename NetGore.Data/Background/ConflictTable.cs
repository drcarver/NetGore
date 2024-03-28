using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Data.Background;

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
public partial class BackgroundTables
{
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
    /// Conflicts Table
    /// </summary>
    public static RandomTable ConflictTable { get; } = new()
    {
        Name = "The Conflicts Table",
        DiceSides = 20,
        Table =
        [
            #region Minor Failure
            //1	Minor Failure   You failed a friend, family member, or loved one who depended on you to fulfill an important task.
            new RandomTableEntry
            {
                LowerRange = 01,
                UpperRange = 01,
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
            //2	Petty Crime You committed a minor crime, like vandalism, trespassing, or mischief.	1
            new RandomTableEntry
            {
                LowerRange = 02,
                UpperRange = 02,
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
            //3	Told a Lie You deliberately made someone believe something that was not true to further your own goals.    1
            new RandomTableEntry
            {
                LowerRange = 03,
                UpperRange = 03,
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
            //4	Broke a Promise You swore an oath or vow that was important to someone else, but you did not keep your promise. 1
            new RandomTableEntry
            {
                LowerRange = 04,
                UpperRange = 04,
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
            //5	Humiliation You publicly humiliated or scandalized someone with either true or slanderous information.  2
            new RandomTableEntry
            {
                LowerRange = 05,
                UpperRange = 05,
                Name = nameof(ConflictEnum.Humiliation),
                Description =
                    "You publicly humiliated or " +
                    "scandalized someone with either " +
                    "true or slanderous information.",
                ConflictPoints = 2
            },
            #endregion

            #region Negligence
            //6	Negligence You caused someone else to suffer by your own inaction, disregard, or excessive recklessness.   2
            new RandomTableEntry
            {
                LowerRange = 06,
                UpperRange = 06,
                Name = nameof(ConflictEnum.Negligence),
                Description =
                    "You caused someone else to suffer " +
                    "by your own inaction, disregard, " +
                    "or excessive recklessness.",
                ConflictPoints = 2
            },
            #endregion

            #region Minor Theft
            //7	Minor Theft You stole several small or inexpensive items that belonged to someone else.	2
            new RandomTableEntry
            {
                LowerRange = 07,
                UpperRange = 07,
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
            //8	Seducer 
            new RandomTableEntry
            {
                LowerRange = 08,
                UpperRange = 08,
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
            //9	Cheater You broke a rule, law, contract, or agreement for your own gain.    3
            new RandomTableEntry
            {
                LowerRange = 09,
                UpperRange = 09,
                Name = nameof(ConflictEnum.Cheater),
                Description =
                    "You broke a rule, law, contract, " +
                    "or agreement for your own gain.",
                ConflictPoints = 3
            },
            #endregion

            #region Betrayal
            //10	Betrayal 
            new RandomTableEntry
            {
                LowerRange = 10,
                UpperRange = 10,
                Name = nameof(ConflictEnum.Betrayal),
                Description =
                    "You betrayed someone who trusted you.",
                ConflictPoints = 4
            },
            #endregion

            #region Malign Associates
            //11	Malign Associates   
            new RandomTableEntry
            {
                LowerRange = 11,
                UpperRange = 11,
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
            //12	Destroyed a Reputation 
            new RandomTableEntry
            {
                LowerRange = 12,
                UpperRange = 12,
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
            //13	Major Theft 
            new RandomTableEntry
            {
                LowerRange = 13,
                UpperRange = 13,
                Name = nameof(ConflictEnum.MajorTheft),
                ProperName = "Major Theft",
                Description =
                    "You stole expensive items.",
                ConflictPoints = 5
            },
            #endregion

            #region Corrupted an Innocent
            //14	Corrupted an Innocent 
            new RandomTableEntry
            {
                LowerRange = 14,
                UpperRange = 14,
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
            //15	Blackmailed You used sensitive knowledge or threats to force someone’s cooperation.	6
            new RandomTableEntry
            {
                LowerRange = 15,
                UpperRange = 15,
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
            new RandomTableEntry
            {
                LowerRange = 16,
                UpperRange = 16,
                Name = nameof(ConflictEnum.Destruction),
                ProperName = "Destruction",
                Description =
                    "You destroyed someone else’s property.",
                ConflictPoints = 6
            },
            #endregion

            #region Armed Robbery
            //17	Armed Robbery
            new RandomTableEntry
            {
                LowerRange = 17,
                UpperRange = 17,
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
            new RandomTableEntry
            {
                LowerRange = 18,
                UpperRange = 18,
                Name = nameof(ConflictEnum.ViolentCrime),
                ProperName = "Violent Crime",
                Description =
                    "You beat, assaulted, or mutilated someone.",
                ConflictPoints = 7
            },
            #endregion

            #region Murder
            //19	Murder
            new RandomTableEntry
            {
                LowerRange = 19,
                UpperRange = 19,
                Name = nameof(ConflictEnum.Murder),
                ProperName = "Murder",
                Description =
                    "Murder You killed someone.",
                ConflictPoints = 8
            },
            #endregion

            #region Mass Murder
            //20	Mass Murder
            new RandomTableEntry
            {
                LowerRange = 20,
                UpperRange = 20,
                Name = nameof(ConflictEnum.MassMurder),
                ProperName = "Mass Murder",
                Description =
                    "You killed several sentient beings.",
                ConflictPoints = 12
            },
            #endregion
        ],
    };
}
