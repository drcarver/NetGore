using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class GuildMember : BaseObject, IGuildMember
{
    /// <summary>
    /// The character that is a member of the guild.
    /// </summary>
    [Description("The character that is a member of the guild.")]
    public Character? Character { get; set; }

    /// <summary>
    /// The guild the member is a part of..
    /// </summary>
    [Description("The guild the member is a part of.")]
    public Guild? Guild { get; set; }

    /// <summary>
    /// When the member joined the guild.
    /// </summary>
    [Description("When the member joined the guild.")]
    public DateTime Joined { get; set; }

    /// <summary>
    /// The member's ranking in the guild.
    /// </summary>
    [Description("The member's ranking in the guild.")]
    public GuildRank Rank { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected GuildMember()
    {
    }
}
