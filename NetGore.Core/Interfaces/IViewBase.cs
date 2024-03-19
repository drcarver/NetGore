using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IViewBase
{
    /// <summary>
    /// The AI used by this character. Null for no AI 
    /// (does nothing, or is user-controller). Intended 
    /// for NPCs only.
    /// </summary>
    AI? AI { get; set; }

    /// <summary>
    /// The body to use to display this character.
    /// </summary>
    Body? Body { get; set; }

    /// <summary>
    /// Amount of cash.
    /// </summary>
    int Cash { get; set; }

    /// <summary>
    /// The template that this character was created 
    /// from (not required - mostly for developer 
    /// reference).
    /// </summary>
    CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The chat dialog that this character displays. 
    /// Null for no chat. Intended for NPCs only.
    /// </summary>
    NPCChatDialog? ChatDialog { get; set; }

    /// <summary>
    /// Experience points.
    /// </summary>
    int Exp { get; set; }

    /// <summary>
    /// Current health points.
    /// </summary>
    int HP { get; set; }

    /// <summary>
    /// Current level.
    /// </summary>
    short Level { get; set; }

    /// <summary>
    /// The map to load on (when logging in / being created).
    /// </summary>
    Map? LoadMap { get; set; }

    /// <summary>
    /// The x coordinate to load at.
    /// </summary>
    ushort LoadX { get; set; }

    /// <summary>
    /// The y coordinate to load at.
    /// </summary>
    ushort LoadY { get; set; }

    /// <summary>
    /// The movement speed of the character.
    /// </summary>
    ushort MoveSpeed { get; set; }

    /// <summary>
    /// Current mana points.
    /// </summary>
    int MP { get; set; }

    /// <summary>
    /// The map to respawn on (when null, cannot respawn).
    /// Used to reposition character after death.
    /// </summary>
    Map? RespawnMap { get; set; }

    /// <summary>
    /// The x coordinate to respawn at.
    /// </summary>
    float RespawnX { get; set; }

    /// <summary>
    /// The y coordinate to respawn at.
    /// </summary>
    float RespawnY { get; set; }

    /// <summary>
    /// The shop that this character runs. Null if not 
    /// a shopkeeper.
    /// </summary>
    Shop? Shop { get; set; }

    /// <summary>
    /// Stat points available to be spent.
    /// </summary>
    int StatPoints { get; set; }

    /// <summary>
    /// Agi stat.
    /// </summary>
    short StatAgi { get; set; }

    /// <summary>
    /// Defence stat.
    /// </summary>
    short StatDefence { get; set; }

    /// <summary>
    /// Int stat.
    /// </summary>
    short StatInt { get; set; }

    /// <summary>
    /// MaxHit stat.
    /// </summary>
    short StatMaxhit { get; set; }

    /// <summary>
    /// MaxHP stat.
    /// </summary>
    short StatMaxhp { get; set; }

    /// <summary>
    /// MaxMP stat.
    /// </summary>
    short StatMaxmp { get; set; }

    /// <summary>
    /// MinHit stat.
    /// </summary>
    short StatMinhit { get; set; }

    /// <summary>
    /// Str stat.
    /// </summary>
    short StatStr { get; set; }
}