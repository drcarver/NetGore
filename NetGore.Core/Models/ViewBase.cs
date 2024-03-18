using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ViewBase : BaseObject, IViewBase
{
    /// <summary>
    /// The AI used by this character. Null for no AI 
    /// (does nothing, or is user-controller). Intended 
    /// for NPCs only.
    /// </summary>
    [Description("The AI used by this character. Null for no AI (does nothing, or is user-controller). Intended for NPCs only.")]
    public AI? AI { get; set; }

    /// <summary>
    /// The body to use to display this character.
    /// </summary>
    [Description("The body to use to display this character.")]
    public Body? Body { get; set; }

    /// <summary>
    /// Amount of cash.
    /// </summary>
    [Description("Amount of cash.")]
    public int Cash { get; set; }

    /// <summary>
    /// The template that this character was created 
    /// from (not required - mostly for developer 
    /// reference).
    /// </summary>
    [Description("The template that this character was created from (not required - mostly for developer reference).")]
    public CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The chat dialog that this character displays. 
    /// Null for no chat. Intended for NPCs only.
    /// </summary>
    [Description("The chat dialog that this character displays. Null for no chat. Intended for NPCs only.")]
    public NPCChatDialog? ChatDialog { get; set; }

    /// <summary>
    /// Experience points.
    /// </summary>
    [Description("Experience points.")]
    public int Exp { get; set; }

    /// <summary>
    /// Current health points.
    /// </summary>
    [Description("Current health points.")]
    public int HP { get; set; }

    /// <summary>
    /// Current level.
    /// </summary>
    [Description("Current level.")]
    public short Level { get; set; }

    /// <summary>
    /// The map to load on (when logging in / being created).
    /// </summary>
    [Description("The map to load on (when logging in / being created).")]
    public Map? LoadMap { get; set; }

    /// <summary>
    /// The x coordinate to load at.
    /// </summary>
    [Description("The x coordinate to load at.")]
    public ushort LoadX { get; set; }

    /// <summary>
    /// The y coordinate to load at.
    /// </summary>
    [Description("The y coordinate to load at.")]
    public ushort LoadY { get; set; }

    /// <summary>
    /// The movement speed of the character.
    /// </summary>
    [Description("The movement speed of the character.")]
    public ushort MoveSpeed { get; set; }

    /// <summary>
    /// Current mana points.
    /// </summary>
    [Description("Current mana points.")]
    public int MP { get; set; }

    /// <summary>
    /// The map to respawn on (when null, cannot respawn).
    /// Used to reposition character after death.
    /// </summary>
    [Description("The map to respawn on (when null, cannot respawn). Used to reposition character after death.")]
    public Map? RespawnMap { get; set; }

    /// <summary>
    /// The x coordinate to respawn at.
    /// </summary>
    [Description("The x coordinate to respawn at.")]
    public float RespawnX { get; set; }

    /// <summary>
    /// The y coordinate to respawn at.
    /// </summary>
    [Description("The y coordinate to respawn at.")]
    public float RespawnY { get; set; }

    /// <summary>
    /// The shop that this character runs. Null if not 
    /// a shopkeeper.
    /// </summary>
    [Description("The shop that this character runs. Null if not a shopkeeper.")]
    public Shop? Shop { get; set; }

    /// <summary>
    /// Stat points available to be spent.
    /// </summary>
    [Description("Stat points available to be spent.")]
    public int StatPoints { get; set; }

    /// <summary>
    /// Agi stat.
    /// </summary>
    [Description("Agi stat.")]
    public short StatAgi { get; set; }

    /// <summary>
    /// Defence stat.
    /// </summary>
    [Description("Defence stat.")]
    public short StatDefence { get; set; }

    /// <summary>
    /// Int stat.
    /// </summary>
    [Description("Int stat.")]
    public short StatInt { get; set; }

    /// <summary>
    /// MaxHit stat.
    /// </summary>
    [Description("MaxHit stat.")]
    public short StatMaxhit { get; set; }

    /// <summary>
    /// MaxHP stat.
    /// </summary>
    [Description("MaxHP stat.")]
    public short StatMaxhp { get; set; }

    /// <summary>
    /// MaxMP stat.
    /// </summary>
    [Description("MaxMP stat.")]
    public short StatMaxmp { get; set; }

    /// <summary>
    /// MinHit stat.
    /// </summary>
    [Description("MinHit stat.")]
    public short StatMinhit { get; set; }

    /// <summary>
    /// Str stat.
    /// </summary>
    public short StatStr { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ViewBase()
    {
    }
}
