using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterTemplate : BaseObject, ICharacterTemplate
{
    /// <summary>
    /// The AI (intended for NPCs only).
    /// </summary>
    [Description("The AI (intended for NPCs only).")]
    public AI? AI { get; set; }

    /// <summary>
    /// The alliance.
    /// </summary>
    [Description("The alliance.")]
    public Alliance? Alliance { get; set; }

    /// <summary>
    /// The body to use.
    /// </summary>
    [Description("The body to use.")]
    public Body? Body { get; set; }

    /// <summary>
    /// The chat dialog (intended for NPCs only).
    /// </summary>
    [Description("The chat dialog (intended for NPCs only).")]
    public NPCChat? ChatDialog { get; set; }

    /// <summary>
    /// Current exp.
    /// </summary>
    [Description("Current exp.")]
    public int Exp { get; set; }

    /// <summary>
    /// Amount of cash to give when killed (intended 
    /// for NPCs only).
    /// </summary>
    [Description("Amount of cash to give when killed (intended for NPCs only).")]
    public int GiveCash { get; set; }

    /// <summary>
    /// Amount of exp to give when killed (intended for 
    /// NPCs only).
    /// </summary>
    [Description("Amount of exp to give when killed (intended for NPCs only).")]
    public int GiveExp { get; set; }

    /// <summary>
    /// The character's level.
    /// </summary>
    [Description("The character's level.")]
    public int Level { get; set; }

    /// <summary>
    /// The movement speed.
    /// </summary>
    [Description("The movement speed.")]
    public int MoveSpeed { get; set; }

    /// <summary>
    /// How long in seconds to wait after death to be 
    /// respawned (intended for NPCs only).
    /// </summary>
    [Description("How long in seconds to wait after death to be respawned (intended for NPCs only).")]
    public int Respawn { get; set; }

    /// <summary>
    /// The shop (intended for NPCs only).
    /// </summary>
    [Description("The shop (intended for NPCs only).")]
    public Shop? Shop { get; set; }

    /// <summary>
    /// Number of stat points available to spend.
    /// </summary>
    [Description("Number of stat points available to spend.")]
    public int StatPoints { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterTemplate()
    {
    }
}
