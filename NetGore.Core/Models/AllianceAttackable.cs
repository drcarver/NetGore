using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class AllianceAttackable : BaseObject, IAllianceAttackable
{
    /// <summary>
    /// The alliance.
    /// </summary>
    [Required]
    [Description("The alliance.")]
    [Comment("The alliance.")]
    public required Alliance Alliance { get; set; }

    /// <summary>
    /// The alliance that this alliance can attack.
    /// </summary>
    [Required]
    [Description("The alliance that this alliance can attack.")]
    [Comment("The alliance that this alliance can attack.")]
    public required Alliance Attackable { get; set; }
}
