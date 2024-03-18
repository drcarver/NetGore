using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Shop : BaseObject, IShop
{
    /// <summary>
    /// Whether or not this shop can buy items from 
    /// shoppers. When false, the shop only sells items 
    /// (users cannot sell to it).
    /// </summary>
    [Description("Whether or not this shop can buy items from shoppers. When false, the shop only sells items (users cannot sell to it).")]
    public bool CanBuy { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Shop()
    {
    }
}
