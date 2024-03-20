using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AppliedPatches : BaseObject, IAppliedPatches
{
    /// <summary>
    /// The datetime the patch was applied.
    /// </summary>
    [Description("The datetime the patch was applied.")]
    public DateTime? DateApplied { get; set; }

    /// <summary>
    /// The filename of the patch that was applied.
    /// </summary>
    [Description("The filename of the patch that was applied.")]
    public string? FileName { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AppliedPatches()
    {
    }
}
