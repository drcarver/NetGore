using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Campaign : BaseObject, ICampaign
{
    /// <summary>
    /// The world for this game
    /// </summary>
    [Description("The World for this game.")]
    public World? World { get; set; }

    /// <summary>
    /// The campaigns for this game.
    /// </summary>
    [Description("The campaigns for this game.")]
    public List<CampaignModule>? Campaigns { get; set; } = [];

    /// <summary>
    /// Create a new Campaign
    /// </summary>
    [SetsRequiredMembers]
    protected Campaign()
    {
    }
}
