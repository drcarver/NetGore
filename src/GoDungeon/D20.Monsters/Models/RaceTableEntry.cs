using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Core.Models;
using D20.Monsters.Interfaces;

namespace D20.Monsters.Models;

internal class RaceTableEntry : RandomTableEntry, IRaceTableEntry
{
    [SetsRequiredMembers]
    public RaceTableEntry()
    {
    }

    /// <summary>
    /// The humanoid race to create
    /// </summary>
    public RaceEnum Race { get; set; }
}
