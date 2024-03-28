using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;

namespace NetGore.Core.Models;

public class Trait : DataObject
{
    //public List<SavingThrowPenality> Effect { get; set; }

    public string ProperName { get; set; }

    //URL,
    public Uri URL { get; set; }

    public ClassEnum CharacterClass { get; set; } = ClassEnum.Any;

    public RaceEnum Race { get; set; } = RaceEnum.Any;

    //Type,
    public TraitTypeEnum TraitType { get; set; }

    //Category,
    public TraitCategoryEnum Category { get; set; }

    public TerrainEnum Terrain { get; set; } = TerrainEnum.Any;

    [SetsRequiredMembers]
    public Trait()
    {
    }
}
