using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterQuestStatusKills : BaseObject, ICharacterQuestStatusKills
{
    /// <summary>
    /// The character who is doing this quest.
    /// </summary>
    [Required]
    [Description("The character who is doing this quest.")]
    [Comment("The character who is doing this quest.")]
    public required Character Character { get; set; }

    /// <summary>
    /// The character template that is to be killed for 
    /// the quest.
    /// </summary>
    [Required]
    [Description("The character template that is to be killed for the quest.")]
    [Comment("The character template that is to be killed for the quest.")]
    public required CharacterTemplate CharacterTemplate { get; set; }

    /// <summary>
    /// The current kill count of characters with this 
    /// template.
    /// </summary>
    [Required]
    [Description("The current kill count of characters with this template.")]
    [Comment("The current kill count of characters with this template.")]
    public required int Count { get; set; }

    /// <summary>
    /// The quest that the kill count is for.
    /// </summary>
    [Required]
    [Description("The quest that the kill count is for.")]
    [Comment("The quest that the kill count is for.")]
    public required Quest Quest { get; set; }
}
