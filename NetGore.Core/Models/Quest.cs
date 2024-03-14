using System.ComponentModel;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Quest : BaseObject, IQuest
{
    /// <summary>
    /// If this quest can be repeated by a character 
    /// after they have completed it.
    /// </summary>
    [Description("If this quest can be repeated by a character after they have completed it.")]
    [Comment("If this quest can be repeated by a character after they have completed it.")]
    public bool Repeatable { get; set; }

    /// <summary>
    /// The base cash reward for completing this quest.
    /// </summary>
    [Description("The base cash reward for completing this quest.")]
    [Comment("The base cash reward for completing this quest.")]
    public int RewardCash { get; set; }

    /// <summary>
    /// The base experience reward for completing this 
    /// quest.
    /// </summary>
    [Description("The base experience reward for completing this quest.")]
    [Comment("The base experience reward for completing this quest.")]
    public int RewardExp { get; set; }
}