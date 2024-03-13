using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ActiveTradeItem : BaseObject, IActiveTradeItem
{
    /// <summary>
    /// The character that added the item.
    /// </summary>
    [Required]
    [Description("The character that added the item.")]
    [Comment("The character that added the item.")]
    public required Character Character { get; set; }

    /// <summary>
    /// The item the character put down.
    /// </summary>
    [Required]
    [Description("The item the character put down.")]
    [Comment("The item the character put down.")]
    public required Item Item { get; set; }
}
