using GoDungeon.Core.Enum;

namespace GoDungeon.CodeGenerator.Interfaces;

public interface IMonster : ICodeGen
{
    /// <summary>
    /// The type of monster
    /// </summary>
    RaceTypeEnum RaceType { get; }

    /// <summary>
    /// The sub type of monster
    /// </summary>
    RaceSubTypeEnum RaceSubType { get; }

    /// <summary>
    /// The challenge rating of the monster
    /// </summary>
    decimal ChallengeRating { get; }
}
