using System;

namespace GoDungeon.Core.Interfaces
{
    public interface IRandomTableEntry : IStandardTableEntry
    {
        /// <summary>
        /// The range for this entry
        /// </summary>
        Range Range { get; set; }
    }
}