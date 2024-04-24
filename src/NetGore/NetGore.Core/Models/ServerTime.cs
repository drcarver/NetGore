using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ServerTime : BaseObject, IServerTime
{
    /// <summary>
    /// The current time of the server, as seen by the 
    /// server process. Only updated when server is 
    /// running. Especially intended for when comparing 
    /// the time to the server's current time. Slightly 
    /// low resolution (assume ~10 seconds).".
    /// </summary>
    [Description("The current time of the server, as seen by the server process. Only updated when server is running. Especially intended for when comparing the time to the server's current time. Slightly low resolution (assume ~10 seconds).")]
    public DateTime ServerDateTime { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ServerTime()
    {
    }
}
