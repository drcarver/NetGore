using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ActiveTradeCash : BaseObject, IActiveTradeCash
{
    /// <summary>
    /// The amount of cash the character put down.
    /// </summary>
    [Required]
    [Description("The amount of cash the character put down.")]
    [Comment("The amount of cash the character put down.")]
    public required int Cash { get; set; }

    /// <summary>
    /// The character that put the cash on the trade 
    /// table.
    /// </summary>
    [Required]
    [Description("The character that put the cash on the trade table.")]
    [Comment("The character that put the cash on the trade table.")]
    public required Character Character { get; set; }
}
