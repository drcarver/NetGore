namespace D20.Core.Interfaces;

public interface IRandomTableEntry : IGameTableEntry
{
    /// <summary>
    /// The range for this entry
    /// </summary>
    Range Range { get; set; }
}