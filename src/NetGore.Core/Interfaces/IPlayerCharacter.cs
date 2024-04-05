namespace NetGore.Core.Interfaces;

public interface IPlayerCharacter
{
    /// <summary>
    /// The character class
    /// </summary>
    List<IClassInformation> ClassInformation { get; }

    /// <summary>
    /// The account for the player who owns this
    /// character
    /// </summary>
    IAccount? Account { get; set; }
}