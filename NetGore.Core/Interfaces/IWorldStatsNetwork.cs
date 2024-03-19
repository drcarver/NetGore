namespace NetGore.Core.Interfaces;

public interface IWorldStatsNetwork
{
    /// <summary>
    /// Number of connections to the server at the time 
    /// of the snapshot.
    /// </summary>
    ushort Connections { get; set; }

    /// <summary>
    /// The average bytes received per second since the 
    /// last snapshot.
    /// </summary>
    uint RecvBytes { get; set; }

    /// <summary>
    /// The average messages received per second since 
    /// the last snapshot.
    /// </summary>
    uint RecvMessages { get; set; }

    /// <summary>
    /// The average packets received per second since 
    /// the last snapshot.
    /// </summary>
    uint RecvPackets { get; set; }

    /// <summary>
    /// The average bytes sent per second since the 
    /// last snapshot.
    /// </summary>
    uint SentBytes { get; set; }

    /// <summary>
    /// The average messages sent per second since the 
    /// last snapshot.
    /// </summary>
    uint SentMessages { get; set; }

    /// <summary>
    /// The average packets sent per second since the 
    /// last snapshot.
    /// </summary>
    uint SentPackets { get; set; }

    /// <summary>
    /// The time the snapshot took place.
    /// </summary>
    DateTime When { get; set; }
}