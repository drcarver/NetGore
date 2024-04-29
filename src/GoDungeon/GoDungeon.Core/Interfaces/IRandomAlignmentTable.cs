using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface IRandomAlignmentTable : IRandomTable
    {
        /// <summary>
        /// The allowed alignments
        /// </summary>
        public AlignmentFilterEnum AlignmentFilter { get; set; }
    }
}