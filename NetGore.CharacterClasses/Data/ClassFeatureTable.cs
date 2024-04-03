using System.Diagnostics.CodeAnalysis;

using NetGore.CharacterClasses.Enum;
using NetGore.CharacterClasses.Models;

namespace NetGore.CharacterClasses.Data;

public class ClassFeatureTable
{
    /// <summary>
    /// Constructor for the table
    /// </summary>
    [SetsRequiredMembers]
    public ClassFeatureTable()
    {
    }

    public List<ClassFeature> ClassFeatures { get; set; } = 
    [
        new ClassFeature
        {
            Name = nameof(ClassFeatureEnum.Rage),
        },
        new ClassFeature
        {
            Name = nameof(ClassFeatureEnum.UnarmoredDefense),
        },
        new ClassFeature
        {
            Name = nameof(ClassFeatureEnum.RecklessAttack),
        },
        new ClassFeature
        {
            Name = nameof(ClassFeatureEnum.DangerSense),
        },
        new ClassFeature
        {
            Name = nameof(ClassFeatureEnum.PrimalPath),
        },
    ];
}
