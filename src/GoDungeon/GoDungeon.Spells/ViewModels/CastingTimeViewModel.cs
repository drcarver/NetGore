using GoDungeon.Core.Enum;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.Spells.ViewModels;

public class CastingTimeViewModel : ICastingTime
{
    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="castingTime">The casting time</param>
    /// <param name="duration">The casting time units</param>
    public CastingTimeViewModel(int castingTime, DurationEnum duration)
    {
        CastingTime = castingTime;
        Duration = duration;
    }

    /// <summary>
    /// Constructor 
    /// </summary>
    public CastingTimeViewModel()
    {
    }

    /// <summary>
    /// The casting time
    /// </summary>
    public int CastingTime { get; set; }

    /// <summary>
    /// The casting duration
    /// </summary>
    public DurationEnum Duration { get; set; }
}
