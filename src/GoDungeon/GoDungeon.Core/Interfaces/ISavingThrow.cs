using CommunityToolkit.Mvvm.ComponentModel;

namespace GoDungeon.Core.Interfaces
{
    public interface ISavingThrow : IBaseObject
    {
        /// <summary>
        /// The modifier for this saving throw (mainly from
        /// the level
        /// </summary>
        int ProficiencyModifier { get; set; }

        /// <summary>
        /// Any class modifiers
        /// </summary>
        int ClassModifier { get; set; }

        /// <summary>
        /// Any Other modifiers
        /// </summary>
        int OtherModifiers { get; set; }

        /// <summary>
        /// Roll the saving throw against the give dc
        /// </summary>
        /// <param name="dc">The difficulty check for this roll</param>
        /// <returns>True if the saving throw succeeds</returns>
        bool Roll(int dc);
    }
}