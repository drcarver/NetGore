namespace NetGore.Core.Interfaces;

public interface IServerTime
{
    /// <summary>
    /// The current time of the server, as seen by the 
    /// server process. Only updated when server is 
    /// running. Especially intended for when comparing 
    /// the time to the server's current time. Slightly 
    /// low resolution (assume ~10 seconds).".
    /// </summary>
    DateTime ServerDateTime { get; set; }
}