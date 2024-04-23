using D20.Core.Enum;
using D20.Core.Interfaces;

namespace D20.Monsters.Interfaces;

public interface IHumanoidRace : ICreature
{
    /// <summary>
    /// The race
    /// </summary>
    public RaceEnum Race { get; set; }
}