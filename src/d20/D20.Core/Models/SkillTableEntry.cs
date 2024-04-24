using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Interfaces;

namespace D20.Core.Models;

/// <summary>
/// The table of creature skill's.
/// </summary>
public class SkillTableEntry : StandardTableEntry, ISkillTableEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public SkillTableEntry()
    {
    }

    /// <summary>
    /// The skill
    /// </summary>
    public SkillEnum Skill { get; internal set; }

    /// <summary>
    /// The enum of the ability whose modifier applies 
    /// to the skill check.
    /// </summary>
    public AbilityEnum Ability { get; internal set; }

    /// <summary>
    /// The skill points for the skill
    /// </summary>
    public int Points { get; set; }

    /// <summary>
    /// Any armor heavier than leather, as well as any shield, 
    /// hurts a character’s ability to use Dex– and Str-based 
    /// skills. An armor check penalty applies to all Dex– and 
    /// Strength-based skill checks.
    /// <para>
    /// If a character is wearing armor and using a shield, 
    /// both armor check penalties apply.
    /// </para>
    /// <para>
    /// A character who wears armor and/or uses a shield with 
    /// which they are not proficient takes the armor’s (and/or 
    /// shield’s) armor check penalty on attack rolls as well 
    /// as on all Dex– and Str-based ability and skill checks.
    /// The penalty for non-proficiency with armor stacks with 
    /// the penalty for shields
    /// </para>
    /// </summary>
    public int ArmorCheckPenalty { get; set; } = 0;

    /// <summary>
    /// You must have at least 1 rank in the skill to use it. If 
    /// this notation is omitted, the skill can be used untrained
    /// If any special notes apply to trained or untrained use, 
    /// they are covered in Untrained section.
    /// </summary>
    public bool TrainedOnly { get; internal set; } = false;

    /// <summary>
    /// This entry indicates what a character without at least 1 
    /// rank in the skill can do with it. If this entry doesn’t 
    /// appear, it means that the skill functions normally for 
    /// untrained characters (if it can be used untrained) or 
    /// that an untrained character can’t attempt checks with 
    /// this skill (for skills that are designated “Trained Only”).
    /// </summary>
    public bool Untrained {  get; internal set; } = true;

    /// <summary>
    /// What a character (“you” in the skill description) can
    /// do with a successful skill check and the check’s Difficulty
    /// Class(DC).
    /// </summary>
    public string? Check { get; internal set; }

    /// <summary>
    /// The type of action using the skill requires, or the
    /// amount of time required for a check.
    /// </summary>
    public string? Action { get; internal set; }

    /// <summary>
    /// Any conditions that apply to successive attempts to 
    /// use the skill successfully. If the skill doesn’t allow 
    /// you to attempt the same task more than once, or if 
    /// failure carries an inherent penalty (such as with 
    /// the Climb skill), you can’t take 20. If this paragraph 
    /// is omitted, the skill can be retried without any 
    /// inherent penalty other than the additional time required.
    /// </summary>
    public string? TryAgain { get; internal set; }

    /// <summary>
    /// Any extra facts that apply to the skill, such as special 
    /// effects deriving from its use or bonuses that certain 
    /// characters receive because of class, feat choices, or race.
    /// </summary>
    public string? Special {  get; internal set; }

    /// <summary>
    /// The full utility of certain skills is restricted to 
    /// characters of certain classes.  This entry indicates 
    /// whether any such restrictions exist for the skill.
    /// </summary>
    public string? Restriction { get; internal set; }
}
