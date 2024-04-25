using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    public partial class AlignmentTableEntryViewModel : RandomTableEntryViewModel, IAlignmentEntry
    {
        /// <summary>
        /// The alignment as a enum
        /// </summary>
        public AlignmentEnum Alignment { get; set; }
    }
}
