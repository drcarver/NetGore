using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Monsters.Interfaces;

namespace D20.Monsters.Models.Humanoid;

public class HumanoidRace : Creature, IHumanoidRace
{
    /// <summary>
    /// Create a new humanoid race 
    /// </summary>
    /// <param name="race">The race</param>
    [SetsRequiredMembers]
    public HumanoidRace()
    {
    }
}
