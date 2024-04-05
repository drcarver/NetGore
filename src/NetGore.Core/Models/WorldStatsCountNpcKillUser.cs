using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountNpcKillUser : BaseObject, IWorldStatsCountNpcKillUser
{
    /// <summary>
    /// The number of times NPCs of this character 
    /// template have killed the user.
    /// </summary>
    [Description("The number of times NPCs of this character template have killed the user.")]
    public int Count { get; set; }

    /// <summary>
    /// The character template this counter is for.
    /// </summary>
    [Description("The character template this counter is for.")]
    public CharacterTemplate? NPCTemplate { get; set; }

    /// <summary>
    /// The character this counter is for (logically,
    /// should be a user).
    /// </summary>
    [Description("The character this counter is for (logically, should be a user).")]
    public PlayerCharacter? User { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected WorldStatsCountNpcKillUser()
    {
    }
}
