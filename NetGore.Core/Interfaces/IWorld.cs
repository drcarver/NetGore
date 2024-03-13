using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorld
{
    List<Campaign>? Campaigns { get; set; }
}