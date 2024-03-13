using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Campaign : BaseObject, ICampaign
{
    /// <summary>
    /// The world for this game
    /// </summary>
    [Required]
    [Comment("The World for this game.")]
    public required World World { get; set; }

    [Required]
    [Comment("The campaigns for this game.")]
    public List<CampaignModule> Campaigns { get; set; } = [];
}
