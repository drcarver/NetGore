using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    public partial class RandomAlignmentTableEntryViewModel : RandomTableEntryViewModel, IAlignmentEntry
    {
        /// <summary>
        /// The alignment as a enum
        /// </summary>
        [ObservableProperty]
        private AlignmentEnum alignment;
    }
}
