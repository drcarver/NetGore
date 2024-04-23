using D20.Core.Enum;

namespace D20.Monsters.Interfaces;

public interface IRaceTableEntry
{
    /// <summary>
    /// The humanoid race to create
    /// </summary>
    public RaceEnum Race { get; set; }
}