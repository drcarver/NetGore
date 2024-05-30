using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.ViewModels
{
    public partial class ChamberExitTableEntryViewModel :  RandomTableEntryViewModel, IChamberExitTableEntry
    {
        /// <summary>
        /// The number of exits from a large chamber
        /// </summary>
        [ObservableProperty]
        private int? largeChamber;

        /// <summary>
        /// The number of exits from a normal chamber
        /// </summary>
        [ObservableProperty]
        private int? normalChamber;
    }
}