using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsGuildUserChange : BaseObject, IWorldStatsGuildUserChange
{
    /// <summary>
    /// The ID of the guild, or null if the user left
    /// a guild.
    /// </summary>
    [Description("The ID of the guild, or null if the user left a guild.")]
    public Guild? Guild { get; set; }

    /// <summary>
    /// The ID of the user who changed the guild they 
    /// are part of.
    /// </summary>
    [Description("The ID of the user who changed the guild they are part of.")]
    public Character? User { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    [Description("When this event took place.")]
    public DateTime When { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected WorldStatsGuildUserChange()
    {
    }
}