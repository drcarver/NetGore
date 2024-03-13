using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICampaign
{
    List<CampaignModule> Campaigns { get; set; }
    World World { get; set; }
}
