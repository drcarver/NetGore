using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class Quest : BaseObject, IQuest
{
    /// <summary>
    /// If this quest can be repeated by a character 
    /// after they have completed it.
    /// </summary>
    [Description("If this quest can be repeated by a character after they have completed it.")]
    public bool Repeatable { get; set; }

    /// <summary>
    /// The base cash reward for completing this quest.
    /// </summary>
    [Description("The base cash reward for completing this quest.")]
    public int RewardCash { get; set; }

    /// <summary>
    /// The base experience reward for completing this 
    /// quest.
    /// </summary>
    [Description("The base experience reward for completing this quest.")]
    public int RewardExp { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected Quest()
    {
    }
}