using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;

namespace NetGore.Core.Models;

public class CampaignModule : BaseObject, ICampaignModule
{
    /// <summary>
    /// The campaign Id for this module.
    /// </summary>
    [Description("The Campaign Id for this module.")]
    public Guid CampaignId { get; set; }

    /// <summary>
    /// The campaign for this module.
    /// </summary>
    [Description("The Campaign for this module.")]
    public Campaign? Campaign { get; set; }

    /// <summary>
    /// Consructor
    /// </summary>
    [SetsRequiredMembers]
    protected CampaignModule()
    {
    }
}