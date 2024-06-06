using GoDungeon.Core.Enum;

namespace GoDungeon.CodeGenerator.Models;

public class MonsterInfo
{
    /// <summary>
    /// The monster name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The monster proper name
    /// </summary>
    public string? ProperName { get; set; }

    /// <summary>
    /// The monster race
    /// </summary>
    public RaceTypeEnum RaceType { get; set; }

    /// <summary>
    /// The monster Challenge rating
    /// </summary>
    public decimal ChallengeRating { get; set; }

    /// <summary>
    /// The terrain where the monster can be found
    /// </summary>
    public TerrainEnum Terrain { get; set; }
}
