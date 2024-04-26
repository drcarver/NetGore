using System.Collections.ObjectModel;

using GoDungeon.Background.Enum;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Background.Interfaces
{
    public interface IBackgroundTableEntry : IRandomTableEntry
    {
        /// <summary>
        /// The racial traits for this creature 
        /// </summary>
        ObservableCollection<TraitEnum> Traits { get; set; }
    }
}