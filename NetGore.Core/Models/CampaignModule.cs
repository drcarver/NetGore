using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace NetGore.Core.Models;

public class CampaignModule : BaseObject
{
    /// <summary>
    /// The campaign for this module.
    /// </summary>
    [Required]
    [Comment("The Campaign for this module.")]
    public required Campaign Campaign { get; set; }
}