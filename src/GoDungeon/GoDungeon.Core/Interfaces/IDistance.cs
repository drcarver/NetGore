using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces;

public interface IDistance
{
    /// <summary>
    /// The distance
    /// </summary>
    int Unit { get; set; }

    /// <summary>
    /// The type of distance
    /// </summary>
    DistanceEnum DistanceType { get; set; }
}