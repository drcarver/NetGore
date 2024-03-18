namespace NetGore.Core.Interfaces;

public interface IQuest
{
    /// <summary>
    /// If this quest can be repeated by a character 
    /// after they have completed it.
    /// </summary>
    bool Repeatable { get; set; }

    /// <summary>
    /// The base cash reward for completing this quest.
    /// </summary>
    int RewardCash { get; set; }

    /// <summary>
    /// The base experience reward for completing this 
    /// quest.
    /// </summary>
    int RewardExp { get; set; }
}