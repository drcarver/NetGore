using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface ISkillTableEntry : IStandardTableEntryViewModel
    {
        /// <summary>
        /// The skill
        /// </summary>
        SkillEnum Skill { get; }

        /// <summary>
        /// The associated ability
        /// </summary>
        AbilityEnum Ability { get; }

        /// <summary>
        /// The skill points for the skill
        /// </summary>
        int Points { get; set; }
    }
}