namespace NetGore.Core.Interfaces;

public interface IQuest
{
    bool Repeatable { get; set; }
    int RewardCash { get; set; }
    int RewardExp { get; set; }
}