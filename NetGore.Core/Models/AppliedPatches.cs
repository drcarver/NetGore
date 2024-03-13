using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AppliedPatches : BaseObject, IAppliedPatches
{
    /// <summary>
    /// The datetime the patch was applied.
    /// </summary>
    [Required]
    [Description("The datetime the patch was applied.")]
    [Comment("The datetime the patch was applied.")]
    public required DateTime DateApplied { get; set; }

    /// <summary>
    /// The filename of the patch that was applied.
    /// </summary>
    [Required]
    [Description("The filename of the patch that was applied.")]
    [Comment("The filename of the patch that was applied.")]
    public required String FileName { get; set; }
}
