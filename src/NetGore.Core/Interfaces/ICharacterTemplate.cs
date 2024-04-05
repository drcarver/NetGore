using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterTemplate
{
    /// <summary>
    /// The AI (intended for NPCs only).
    /// </summary>
    AI? AI { get; set; }

    /// <summary>
    /// The alliance.
    /// </summary>
    Alliance? Alliance { get; set; }

    /// <summary>
    /// The body to use.
    /// </summary>
    Body? Body { get; set; }

    /// <summary>
    /// The chat dialog (intended for NPCs only).
    /// </summary>
    NPCChat? ChatDialog { get; set; }

    /// <summary>
    /// Current exp.
    /// </summary>
    int Exp { get; set; }

    /// <summary>
    /// Amount of cash to give when killed (intended 
    /// for NPCs only).
    /// </summary>
    int GiveCash { get; set; }

    /// <summary>
    /// Amount of exp to give when killed (intended for 
    /// NPCs only).
    /// </summary>
    int GiveExp { get; set; }

    /// <summary>
    /// The character's level.
    /// </summary>
    int Level { get; set; }

    /// <summary>
    /// The movement speed.
    /// </summary>
    int MoveSpeed { get; set; }

    /// <summary>
    /// How long in seconds to wait after death to be 
    /// respawned (intended for NPCs only).
    /// </summary>
    int Respawn { get; set; }

    /// <summary>
    /// The shop (intended for NPCs only).
    /// </summary>
    Shop? Shop { get; set; }

    /// <summary>
    /// Number of stat points available to spend.
    /// </summary>
    int StatPoints { get; set; }
}