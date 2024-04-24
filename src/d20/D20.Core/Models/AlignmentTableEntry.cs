using D20.Core.Enum;

namespace D20.Core.Models
{
    public class AlignmentTableEntry : RandomTableEntry
    {
        /// <summary>
        /// The alignment as a enum
        /// </summary>
        public AlignmentEnum Alignment { get; set; }
    }
}
