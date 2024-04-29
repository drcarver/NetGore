using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface IAlignmentEntry : INamedTableEntry
    {
        /// <summary>
        /// The alignment as a enum
        /// </summary>
        AlignmentEnum Alignment { get; set; }
    }
}