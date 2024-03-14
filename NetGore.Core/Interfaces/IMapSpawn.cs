using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces
{
    public interface IMapSpawn
    {
        int Amount { get; set; }
        CharacterTemplate CharacterTemplate { get; set; }
        Direction Direction { get; set; }
        int? Height { get; set; }
        Map Map { get; set; }
        int Respawn { get; set; }
        int? Width { get; set; }
        int? X { get; set; }
        int? Y { get; set; }
    }
}