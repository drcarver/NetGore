namespace GoDungeon.MAUI.DungeonMap.Interfaces;

public interface ISettlement
{
    /// <summary>
    /// THe population of the city
    /// </summary>
    string? Population { get; internal set; }

    /// <summary>
    /// The type of government
    /// </summary>
    string? Government { get; internal set; }

    /// <summary>
    /// The type of defense the settlement has
    /// </summary>
    string? Defense { get; internal set; }

    /// <summary>
    /// The types of commerce of for the settlement
    /// </summary>
    string? Commerce { get; internal set; }

    /// <summary>
    /// The organizations in the city
    /// </summary>
    string? Organizations { get; internal set; }
}