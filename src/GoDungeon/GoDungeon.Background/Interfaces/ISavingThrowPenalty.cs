using CommunityToolkit.Mvvm.ComponentModel;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Background.Interfaces
{
    public interface ISavingThrowPenalty : IDataObject
    {
        /// <summary>
        /// The saving throw
        /// </summary>
        SavingThrowEnum SavingThrow { get; set; }

        /// <summary>
        /// The penalty
        /// </summary>
        int Penalty { get; set; }
    }
}