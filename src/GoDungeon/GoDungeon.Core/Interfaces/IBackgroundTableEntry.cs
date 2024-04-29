using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface IBackgroundTableEntry : IRandomTableEntry
    {
        /// <summary>
        /// The racial traits for this creature 
        /// </summary>
        ObservableCollection<TraitEnum> Traits { get; set; }
    }
}