using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    /// <summary>
    /// The table of creature skill's.
    /// </summary>
    public partial class SkillTableEntryViewModel : StandardTableEntryViewModel, ISkillTableEntry
    {
        /// <summary>
        /// The skill
        /// </summary>
        [ObservableProperty]
        private SkillEnum skill;

        /// <summary>
        /// The enum of the ability whose modifier applies 
        /// to the skill check.
        /// </summary>
        [ObservableProperty]
        private AbilityEnum ability;

        /// <summary>
        /// The skill points for the skill
        /// </summary>
        [ObservableProperty]
        private int points;

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
        [ObservableProperty]
        private int armorCheckPenalty = 0;

        /// <summary>
        /// You must have at least 1 rank in the skill to use it. If 
        /// this notation is omitted, the skill can be used untrained
        /// If any special notes apply to trained or untrained use, 
        /// they are covered in Untrained section.
        /// </summary>
        [ObservableProperty]
        private bool trainedOnly = true;

        /// <summary>
        /// This entry indicates what a character without at least 1 
        /// rank in the skill can do with it. If this entry doesn’t 
        /// appear, it means that the skill functions normally for 
        /// untrained characters (if it can be used untrained) or 
        /// that an untrained character can’t attempt checks with 
        /// this skill (for skills that are designated “Trained Only”).
        /// </summary>
        [ObservableProperty]
        public bool untrained = true;

        /// <summary>
        /// What a character (“you” in the skill description) can
        /// do with a successful skill check and the check’s Difficulty
        /// Class(DC).
        /// </summary>
        [ObservableProperty]
        private string? check;

        /// <summary>
        /// The type of action using the skill requires, or the
        /// amount of time required for a check.
        /// </summary>
        [ObservableProperty]
        private string? action;

        /// <summary>
        /// Any conditions that apply to successive attempts to 
        /// use the skill successfully. If the skill doesn’t allow 
        /// you to attempt the same task more than once, or if 
        /// failure carries an inherent penalty (such as with 
        /// the Climb skill), you can’t take 20. If this paragraph 
        /// is omitted, the skill can be retried without any 
        /// inherent penalty other than the additional time required.
        /// </summary>
        [ObservableProperty]
        private string? tryAgain;

        /// <summary>
        /// Any extra facts that apply to the skill, such as special 
        /// effects deriving from its use or bonuses that certain 
        /// characters receive because of class, feat choices, or race.
        /// </summary>
        [ObservableProperty]
        private string? special;

        /// <summary>
        /// The full utility of certain skills is restricted to 
        /// characters of certain classes.  This entry indicates 
        /// whether any such restrictions exist for the skill.
        /// </summary>
        [ObservableProperty]
        private string? restriction;
    }
}
