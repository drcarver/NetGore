using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class GuildMember : BaseObject, IGuildMember
{
    /// <summary>
    /// The character that is a member of the guild.
    /// </summary>
    [Description("The character that is a member of the guild.")]
    [Comment("The character that is a member of the guild.")]
    public required Character Character { get; set; }

    /// <summary>
    /// The guild the member is a part of..
    /// </summary>
    [Required]
    [Description("The guild the member is a part of.")]
    [Comment("The guild the member is a part of.")]
    public required Guild Guild { get; set; }

    /// <summary>
    /// When the member joined the guild.
    /// </summary>
    [Description("When the member joined the guild.")]
    [Comment("When the member joined the guild.")]
    public DateTime Joined { get; set; }

    /// <summary>
    /// The member's ranking in the guild.
    /// </summary>
    [Description("The member's ranking in the guild.")]
    [Comment("The member's ranking in the guild.")]
    public GuildRank Rank { get; set; }

}
