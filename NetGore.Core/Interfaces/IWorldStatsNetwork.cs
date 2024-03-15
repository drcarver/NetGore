namespace NetGore.Core.Interfaces;

public interface IWorldStatsNetwork
{
    ushort Connections { get; set; }
    uint RecvBytes { get; set; }
    uint RecvMessages { get; set; }
    uint RecvPackets { get; set; }
    uint SentBytes { get; set; }
    uint SentMessages { get; set; }
    uint SentPackets { get; set; }
    DateTime When { get; set; }
}