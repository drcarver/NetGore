using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class World : BaseObject, IWorld
{
    public List<Campaign>? Campaigns { get; set; }
}
