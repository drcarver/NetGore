using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Character.Interfaces
{
    public interface IDeityTableEntry : IStandardTableEntry
    {
        /// <summary>
        /// The deity alignment
        /// </summary>
        AlignmentEnum Alignment { get; set; }

        /// <summary>
        /// The deity symbol(s)
        /// </summary>
        string? Symbol { get; set; }

        /// <summary>
        /// The suggested classes for this deity
        /// </summary>
        ObservableCollection<ClassEnum> SuggestedClasses { get; set; }
    }
}