using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IGuildMember
{
    /// <summary>
    /// The character that is a member of the guild.
    /// </summary>
    PlayerCharacter? Character { get; set; }

    /// <summary>
    /// The guild the member is a part of..
    /// </summary>
    Guild? Guild { get; set; }

    /// <summary>
    /// When the member joined the guild.
    /// </summary>
    DateTime Joined { get; set; }

    /// <summary>
    /// The member's ranking in the guild.
    /// </summary>
    GuildRank Rank { get; set; }
}