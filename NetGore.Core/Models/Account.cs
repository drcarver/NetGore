using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Net;

using NetGore.Core.Interfaces;
using NetGore.Core.Base;

namespace NetGore.Core.Models;

public class Account : BaseObject, IAccount
{
    /// <summary>
    /// The IP address that created the account.
    /// </summary>
    [Required]
    [Description("The IP address that created the account.")]
    public required string? CreatorIp { get; set; }

    /// <summary>
    /// IP address currently logged in to the account, or 
    /// null if nobody is logged in.
    /// </summary>
    [Required]
    [Description("IP address currently logged in to the account, or null if nobody is logged in.")]
    public required string? CurrentIp { get; set; }

    /// <summary>
    /// The email address.
    /// </summary>
    [Description("The email address.")]
    public string? Email { get; set; }

    /// <summary>
    /// A list of friends that the user has.
    /// </summary>
    [Description("A list of friends that the user has.")]
    public string? Friends { get; set; }

    /// <summary>
    /// The account password (MD5 hashed).
    /// </summary>
    [Description("The account password (MD5 hashed).")]
    public string? Password { get; set; }

    /// <summary>
    /// The permission level bit mask (see UserPermissions 
    /// enum).
    /// </summary>
    [Description("The permission level bit mask (see UserPermissions enum).")]
    public UserPermissions? Permissions { get; set; }

    /// <summary>
    /// When the account was last logged in to.
    /// </summary>
    [Required]
    [Description("When the account was last logged in to.")]
    public required DateTime TimeLastLogin { get; set; }

    /// <summary>
    /// Not null if the accounts is banned
    /// </summary>
    [Description("Not null if the accounts is banned.")]
    public AccountBan? AccountBan { get; set; }

    /// <summary>
    /// The List of IP's that have logged into the account.
    /// </summary>
    [Description("The List of IP's that have logged into the account..")]
    public List<AccountIP>? AccountIPList { get; set; }

    /// <summary>
    /// Create a new Account
    /// </summary>
    [SetsRequiredMembers]
    public Account()
    {
        string? localIP;
        using (Socket socket = new(AddressFamily.InterNetwork, SocketType.Dgram, 0))
        {
            socket.Connect("8.8.8.8", 65530);
            IPEndPoint? endPoint = socket.LocalEndPoint as IPEndPoint;
            localIP = endPoint?.Address.ToString();
        }
        TimeLastLogin = DateTime.UtcNow;
        CreatorIp = CurrentIp = localIP;
    }
}
