using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountUserKillNpc
{
    int Count { get; set; }
    DateTime LastUpdate { get; set; }
    CharacterTemplate NPCTemplate { get; set; }
    Character User { get; set; }
}