using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class ByLengthViewModel : EquipmentTableEntryViewModel, IByLength
    {
        /// <summary>
        /// The Length of the object
        /// </summary>
        [ObservableProperty]
        private IHeight? length;
    }
}
