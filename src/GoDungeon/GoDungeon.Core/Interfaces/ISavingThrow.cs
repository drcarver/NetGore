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
        /// <param name="proficiency">The creatures proficiency</param>
        bool Roll(int dc, int proficiency = 0);
    }
}