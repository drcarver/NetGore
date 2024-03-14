using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class QuestRequireStartQuest : BaseObject, IQuestRequireStartQuest
{
    /// <summary>
    /// The quest that this requirement is for.
    /// </summary>
    [Required]
    [Description("The quest that this requirement is for.")]
    [Comment("The quest that this requirement is for.")]
    public required Quest Quest { get; set; }

    /// <summary>
    /// The quest that is required to be finished before 
    /// this quest can be started.
    /// </summary>
    [Required]
    [Description("The quest that is required to be finished before this quest can be started.")]
    [Comment("The quest that is required to be finished before this quest can be started.")]
    public required Quest ReqQuest { get; set; }
}
