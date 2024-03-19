using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IMapSpawn
{
    /// <summary>
    /// The total number of NPCs this spawner will spawn.
    /// </summary>
    int Amount { get; set; }

    /// <summary>
    /// The character template used to instantiate the 
    /// spawned NPCs.
    /// </summary>
    CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The direction of this spawn; None if random.
    /// </summary>
    Direction Direction { get; set; }

    /// <summary>
    /// The height of the spawner (NULL indicates the 
    /// bottom- side of the map).
    /// </summary>
    int? Height { get; set; }

    /// <summary>
    /// The map that this spawn takes place on.
    /// </summary>
    Map? Map { get; set; }

    /// <summary>
    /// How long in seconds to wait after death to be 
    /// respawned (intended for NPCs only).
    /// </summary>
    int Respawn { get; set; }

    /// <summary>
    /// The width of the spawner (NULL indicates the 
    /// right-most side of the map).
    /// </summary>
    int? Width { get; set; }

    /// <summary>
    /// The x coordinate of the spawner (NULL indicates
    /// the left-most side of the map). Example: All 
    /// x/y/width/height set to NULL spawns NPCs 
    /// anywhere on the map.
    /// </summary>
    int? X { get; set; }

    /// <summary>
    /// The y coordinate of the spawner (NULL indicates 
    /// the top-most side of the map).
    /// </summary>
    int? Y { get; set; }
}