using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICampaign
{
    /// <summary>
    /// The world for this game
    /// </summary>
    World? World { get; set; }

    /// <summary>
    /// The campaigns for this game.
    /// </summary>
    List<CampaignModule>? Campaigns { get; set; }
}
