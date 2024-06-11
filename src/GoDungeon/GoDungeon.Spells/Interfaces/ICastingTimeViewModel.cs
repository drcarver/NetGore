using GoDungeon.Core.Enum;

namespace GoDungeon.Spells.Interfaces;

public interface ICastingTime
{
    /// <summary>
    /// The casting time
    /// </summary>
    int CastingTime { get; set; }

    /// <summary>
    /// The casting duration
    /// </summary>
    DurationEnum Duration { get; set; }
}