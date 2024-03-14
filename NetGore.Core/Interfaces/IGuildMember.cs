using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IGuildMember
{
    Character Character { get; set; }
    Guild Guild { get; set; }
    DateTime Joined { get; set; }
    GuildRank Rank { get; set; }
}