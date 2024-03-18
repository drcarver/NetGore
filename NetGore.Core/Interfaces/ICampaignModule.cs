using System.ComponentModel;

namespace NetGore.Core.Models;

public interface ICampaignModule
{
    /// <summary>
    /// The campaign Id for this module.
    /// </summary>
    Guid CampaignId { get; set; }

    /// <summary>
    /// The campaign for this module.
    /// </summary>
    Campaign? Campaign { get; set; }
}