using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Character.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Character.ViewModels
{
    public partial class DeityTableEntryViewModel : StandardTableEntryViewModel, IDeityTableEntry
    {
        /// <summary>
        /// The deity alignment
        /// </summary>
        [ObservableProperty]
        private AlignmentEnum alignment;

        /// <summary>
        /// The deity symbol(s)
        /// </summary>
        [ObservableProperty]
        private string? symbol;

        /// <summary>
        /// The suggested classes for this deity
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<ClassEnum> suggestedClasses = new ObservableCollection<ClassEnum>();
    }
}
