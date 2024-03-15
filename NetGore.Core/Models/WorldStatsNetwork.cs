using System.ComponentModel;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsNetwork : BaseObject, IWorldStatsNetwork
{
    /// <summary>
    /// Number of connections to the server at the time 
    /// of the snapshot.
    /// </summary>
    [Description("Number of connections to the server at the time of the snapshot.")]
    [Comment("Number of connections to the server at the time of the snapshot.")]
    public ushort Connections { get; set; }

    /// <summary>
    /// The average bytes received per second since the 
    /// last snapshot.
    /// </summary>
    [Description("The average bytes received per second since the last snapshot.")]
    [Comment("The average bytes received per second since the last snapshot.")]
    public uint RecvBytes { get; set; }

    /// <summary>
    /// The average messages received per second since 
    /// the last snapshot.
    /// </summary>
    [Description("The average messages received per second since the last snapshot.")]
    [Comment("The average messages received per second since the last snapshot.")]
    public uint RecvMessages { get; set; }

    /// <summary>
    /// The average packets received per second since 
    /// the last snapshot.
    /// </summary>
    [Description("The average packets received per second since the last snapshot.")]
    [Comment("The average packets received per second since the last snapshot.")]
    public uint RecvPackets { get; set; }

    /// <summary>
    /// The average bytes sent per second since the 
    /// last snapshot.
    /// </summary>
    [Description("The average bytes sent per second since the last snapshot.")]
    [Comment("The average bytes sent per second since the last snapshot.")]
    public uint SentBytes { get; set; }

    /// <summary>
    /// The average messages sent per second since the 
    /// last snapshot.
    /// </summary>
    [Description("The average messages sent per second since the last snapshot.")]
    [Comment("The average messages sent per second since the last snapshot.")]
    public uint SentMessages { get; set; }

    /// <summary>
    /// The average packets sent per second since the 
    /// last snapshot.
    /// </summary>
    [Description("The average packets sent per second since the last snapshot.")]
    [Comment("The average packets sent per second since the last snapshot.")]
    public uint SentPackets { get; set; }

    /// <summary>
    /// The time the snapshot took place.
    /// </summary>
    [Description("The time the snapshot took place.")]
    [Comment("The time the snapshot took place.")]
    public DateTime When { get; set; }
}
