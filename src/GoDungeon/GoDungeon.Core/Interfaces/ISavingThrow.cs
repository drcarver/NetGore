using CommunityToolkit.Mvvm.ComponentModel;

namespace GoDungeon.Core.Interfaces
{
    public interface ISavingThrow : IBaseObject
    {
        /// <summary>
        /// True if specific to the class
        /// </summary>
        bool IsClassSavingThrow { get; set; }

        /// <summary>
        /// Any Other modifiers
        /// </summary>
        int OtherModifiers { get; set; }

        /// <summary>
        /// Any race modifiers
        /// </summary>
        int RacialModifier { get; set; }

        /// <summary>
        /// Roll the saving throw against the give dc
        /// </summary>
        /// <param name="dc">The difficulty check for this roll</param>
        /// <returns>True if the saving throw succeeds</returns>
        bool Roll(int dc, int proficiencyModifier = 0);
    }
}