namespace NetGore.CharacterClasses.Interfaces;

/// <summary>
/// The base for all class features
/// </summary>
public interface IBaseClassFeatureEntry
{
    /// <summary>
    /// The base list fo class features
    /// </summary>
    List<IClassFeature> ClassFeatures { get; set; }

    /// <summary>
    /// The level the feature is achieved
    /// </summary>
    int Level { get; set; }

    /// <summary>
    /// The proficiency bonus for the level
    /// </summary>
    int ProficiencyBonus { get; set; }
}