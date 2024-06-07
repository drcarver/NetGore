using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Monsters.Interfaces;

public interface IMonsterInfo : IBaseObject
{
    /// <summary>
    /// The monster race
    /// </summary>
    RaceTypeEnum RaceType { get; set; }

    /// <summary>
    /// The monster Challenge rating
    /// </summary>
    decimal ChallengeRating { get; set; }

    /// <summary>
    /// The terrain where the monster can be found
    /// </summary>
    public TerrainEnum Terrain { get; set; }
}