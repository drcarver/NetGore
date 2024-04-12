using D20.Core.Interfaces;

namespace D20.Character.Interfaces;

public interface IRace
{
    /// <summary>
    /// Generate the character background
    /// </summary>
    /// <param name="homelandTable">The character's homeland</param>
    /// <param name="unusualHomelandTable">An unusual homeland</param>
    /// <param name="parentsTable">The parents table</param>
    /// <param name="siblingsTable">The siblings table</param>
    /// <param name="relativeAgeofSiblings">The relative age of the siblings</param>
    void GenerateBackground(
        IRandomTable homelandTable,
        IRandomTable unusualHomelandTable,
        IRandomTable parentsTable,
        IRandomTable siblingsTable,
        IRandomTable relativeAgeofSiblings);
}