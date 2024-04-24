namespace D20.Core.Interfaces;

public interface IAcrobaticsModifiersTableEntry : INamedTableEntry
{
    /// <summary>
    /// The difficulty check modifier
    /// </summary>
    int DifficultyCheckModifier { get; }
}