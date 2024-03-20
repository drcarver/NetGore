using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountUserKillNpc : BaseObject, IWorldStatsCountUserKillNpc
{
    /// <summary>
    /// Total number of NPCs killed by this user.
    /// </summary>
    [Description("Total number of NPCs killed by this user.")]
    public int Count { get; set; }

    /// <summary>
    /// The character template that this NPC kill 
    /// counter is for.
    /// </summary>
    [Description("The character template that this NPC kill counter is for.")]
    public CharacterTemplate? NPCTemplate { get; set; }

    /// <summary>
    /// The user that this kill counter is for.
    /// </summary>
    [Description("The user that this kill counter is for.")]
    public Character? User { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected WorldStatsCountUserKillNpc()
    {
    }
}
