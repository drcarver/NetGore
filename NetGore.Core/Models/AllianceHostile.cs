using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AllianceHostile : BaseObject, IAllianceHostile
{
    /// <summary>
    /// The alliance that is hotile.
    /// </summary>
    [Required]
    [Description("The alliance that is hostile.")]
    [Comment("The alliance that is hostile.")]
    public required Alliance Alliance { get; set; }

    /// <summary>
    /// The alliance that this alliance is hostile towards 
    /// by default.
    /// </summary>
    [Required]
    [Description("The alliance that this alliance (alliance_id) is hostile towards by default.")]
    [Comment("The alliance that is hostile.")]
    public required Alliance Hostile { get; set; }
}
