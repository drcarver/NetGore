using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ActiveTradeCash : BaseObject, IActiveTradeCash
{
    /// <summary>
    /// The amount of cash the character put down.
    /// </summary>
    [Required]
    [Description("The amount of cash the character put down.")]
    public required int Cash { get; set; }

    /// <summary>
    /// The character that put the cash on the trade 
    /// table.
    /// </summary>
    [Description("The character that put the cash on the trade table.")]
    public Character? Character { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ActiveTradeCash()
    {
        Cash = 0;
    }
}
