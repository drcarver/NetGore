using D20.Character.Enum;
using D20.Core.Enum;
using D20.Core.Interfaces;

namespace D20.Character.Interfaces;

public interface IDeityTableEntry : IGameTableEntry
{
    /// <summary>
    /// The deity alignment
    /// </summary>
    AlignmentEnum Alignment { get; set; }

    /// <summary>
    /// The deity symbol(s)
    /// </summary>
    string? Symbol { get; set; }

    /// <summary>
    /// The suggested classes for this deity
    /// </summary>
    List<ClassEnum> SuggestedClasses { get; set; }

}