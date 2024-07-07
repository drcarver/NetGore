using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface IRandomAlignmentTable : IRandomTable
    {
        /// <summary>
        /// The allowed alignments
        /// </summary>
        public AlignmentEnum AlignmentFilter { get; set; }
    }
}