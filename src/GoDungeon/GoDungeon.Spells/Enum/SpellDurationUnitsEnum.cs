namespace GoDungeon.Spells.Enum;

/// <summary>
/// A spell’s duration is the length of time the spell persists. A duration can be 
/// expressed in rounds, minutes, hours, or even years. Some spells specify that 
/// their effects last until the spells are dispelled or destroyed.
/// </summary>
public enum SpellDurationUnitsEnum
{
    /// <summary>
    /// Many spells are instantaneous. The spell harms, heals, creates, or alters 
    /// a creature or an object in a way that can’t be dispelled, because its 
    /// magic exists only for an instant.
    /// </summary>
    Instantaneous,

    /// <summary>
    /// Some spells require you to maintain concentration in order to keep their 
    /// magic active. If you lose concentration, such a spell ends.
    /// <para>
    /// If a spell must be maintained with concentration, that fact appears in its 
    /// Duration entry, and the spell specifies how long you can concentrate on it. 
    /// You can end concentration at any time (no action required).
    /// </para>
    /// <para>
    /// Normal activity, such as moving and attacking, doesn’t interfere with concentration. 
    /// </para>
    /// </summary>
    Concentration,

    /// <summary>
    /// The spell lasts for hours
    /// </summary>
    Hours,

    /// <summary>
    /// The spell lasts for a hour
    /// </summary>
    Hour,

    /// <summary>
    /// The spell lasts for a minute
    /// </summary>
    Minute,

    /// <summary>
    /// The spell lasts for minutes
    /// </summary>
    Minutes,

    /// <summary>
    /// The spell lasts for a round
    /// </summary>
    Round,

    /// <summary>
    /// The spell lasts for days
    /// </summary>
    Days,

    /// <summary>
    /// The spell lasts a day
    /// </summary>
    Day,

    /// <summary>
    /// The spell lasts Until dispelled
    /// </summary>
    UntilDispelled,

    /// <summary>
    /// The duration of the spell is Special
    /// </summary>
    Special,
    UntilDispelledorTriggered,
}
