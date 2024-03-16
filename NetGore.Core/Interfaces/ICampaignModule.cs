namespace NetGore.Core.Models;

public interface ICampaignModule
{
    /// <summary>
    /// The campaign for this module.
    /// </summary>
    Campaign? Campaign { get; set; }
}