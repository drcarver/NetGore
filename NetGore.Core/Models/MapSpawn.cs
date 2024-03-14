using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class MapSpawn : BaseObject, IMapSpawn
{
    /// <summary>
    /// The total number of NPCs this spawner will spawn.
    /// </summary>
    [Description("The total number of NPCs this spawner will spawn.")]
    [Comment("The total number of NPCs this spawner will spawn.")]
    public int Amount { get; set; }

    /// <summary>
    /// The character template used to instantiate the 
    /// spawned NPCs.
    /// </summary>
    [Required]
    [Description("The character template used to instantiate the spawned NPCs.")]
    [Comment("The character template used to instantiate the spawned NPCs.")]
    public required CharacterTemplate CharacterTemplate { get; set; }

    /// <summary>
    /// The direction of this spawn; None if random.
    /// </summary>
    [Description("The direction of this spawn; None if random")]
    [Comment("The direction of this spawn; None if random")]
    public Direction Direction { get; set; }

    /// <summary>
    /// The height of the spawner (NULL indicates the 
    /// bottom- side of the map).
    /// </summary>
    [Description("The height of the spawner (NULL indicates the bottom- side of the map).")]
    [Comment("The height of the spawner (NULL indicates the bottom- side of the map).")]
    public int? Height { get; set; }

    /// <summary>
    /// The map that this spawn takes place on.
    /// </summary>
    [Required]
    [Description("The map that this spawn takes place on.")]
    [Comment("The map that this spawn takes place on.")]
    public required Map Map { get; set; }

    /// <summary>
    /// How long in seconds to wait after death to be 
    /// respawned (intended for NPCs only).
    /// </summary>
    [Description("How long in seconds to wait after death to be respawned (intended for NPCs only).")]
    [Comment("How long in seconds to wait after death to be respawned (intended for NPCs only).")]
    public int Respawn { get; set; }

    /// <summary>
    /// The width of the spawner (NULL indicates the 
    /// right-most side of the map).
    /// </summary>
    [Description("The width of the spawner (NULL indicates the right-most side of the map).")]
    [Comment("The width of the spawner (NULL indicates the right-most side of the map).")]
    public int? Width { get; set; }

    /// <summary>
    /// The x coordinate of the spawner (NULL indicates
    /// the left-most side of the map). Example: All 
    /// x/y/width/height set to NULL spawns NPCs 
    /// anywhere on the map.
    /// </summary>
    [Description("The x coordinate of the spawner (NULL indicates the left-most side of the map). Example: All x/y/width/height set to NULL spawns NPCs anywhere on the map.")]
    [Comment("The x coordinate of the spawner (NULL indicates the left-most side of the map). Example: All x/y/width/height set to NULL spawns NPCs anywhere on the map.")]
    public int? X { get; set; }

    /// <summary>
    /// The y coordinate of the spawner (NULL indicates 
    /// the top-most side of the map).
    /// </summary>
    [Description("The y coordinate of the spawner (NULL indicates the top-most side of the map).")]
    [Comment("The y coordinate of the spawner (NULL indicates the top-most side of the map).")]
    public int? Y { get; set; }
}
