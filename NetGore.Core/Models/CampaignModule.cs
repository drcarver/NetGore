using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace NetGore.Core.Models;

public class CampaignModule : BaseObject, ICampaignModule
{
    /// <summary>
    /// The campaign for this module.
    /// </summary>
    [Description("The Campaign for this module.")]
    public Campaign? Campaign { get; set; }

    /// <summary>
    /// Create a new Campaign
    /// </summary>
    [SetsRequiredMembers]
    protected CampaignModule()
    {
    }
}