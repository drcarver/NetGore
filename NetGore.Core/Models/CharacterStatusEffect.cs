using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterStatusEffect : BaseObject, ICharacterStatusEffect
{
    /// <summary>
    /// The Character that the status effect is on.
    /// </summary>
    [Required]
    [Description("The Character that the status effect is on.")]
    [Comment("The Character that the status effect is on.")]
    public required Character Character { get; set; }

    /// <summary>
    /// The status effect instance.".
    /// </summary>
    [Required]
    [Description("The status effect instance.")]
    [Comment("The status effect instance.")]
    public required ActiveStatusEffect ActiveStatusEffect { get; set; }

    /// <summary>
    /// The power of this status effect instance.
    /// </summary>
    [Description("The power of this status effect instance.")]
    [Comment("The power of this status effect instance.")]
    public int Power { get; set; }

    /// <summary>
    /// The status effect that this effect is for. This 
    /// corresponds to the StatusEffectType enum's value.
    /// </summary>
    [Comment("The status effect that this effect is for. This corresponds to the StatusEffectType enum's value.")]
    [Description("The status effect that this effect is for. This corresponds to the StatusEffectType enum's value.")]
    public StatusEffectType StatusEffect { get; set; }

    /// <summary>
    /// The amount of time remaining for this status 
    /// effect in seconds.
    /// </summary>
    [Description("The amount of time remaining for this status effect in seconds.")]
    [Comment("The amount of time remaining for this status effect in seconds.")]
    public int TimeLeftSecs { get; set; }
}
